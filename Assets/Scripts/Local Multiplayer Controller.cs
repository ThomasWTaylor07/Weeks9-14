using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class LocalMultiplayerController : MonoBehaviour
{
    public LocalMultiplayerManager manager;
    public PlayerInput playerInput;
    public Vector2 movementInput;
    public float speed = 5;
    public Coroutine doCoroutine;
    public Coroutine startDashcoroutine;
    public bool dash;
    public GameObject trail;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movementInput * speed * Time.deltaTime;
    }
    public void onMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();

    }
    public void onAttack(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            Debug.Log("Player" + playerInput.playerIndex + "Attack");
            manager.playerAttacking(playerInput);
        }

    }

    public void onInteract(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            if (doCoroutine != null)
            {
               
                StopCoroutine(doCoroutine);
            }
            if (startDashcoroutine != null)
            {
                StopCoroutine(startDashcoroutine);
            }
            doCoroutine = StartCoroutine(startDashing());
        }

        IEnumerator startDashing()
        {
            yield return startDashcoroutine = StartCoroutine(playerDash());
        }

        IEnumerator playerDash()
        {
            dash = true;
            Debug.Log("DASH");
            float t = 0;
            while (t < 0.6)
            {
                trail.SetActive(true);
                t += Time.deltaTime;
                speed = 10;
                yield return null;

            }
            speed = 5;
            dash = false;
            trail.SetActive(false);
        }
    }
}
