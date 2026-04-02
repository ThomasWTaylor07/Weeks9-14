using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class MouseMovement : MonoBehaviour
{
    public Vector2 movement;
    public float speed = 5;
    public float time = 0;
    public Coroutine DoCoroutine;
    public Coroutine lerp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LERP()
    {
        if (DoCoroutine != null)
        {
            StopCoroutine(DoCoroutine);
        }
        if (lerp != null)
        {
            StopCoroutine(lerp);
        }
        DoCoroutine = StartCoroutine(newLerp());

        IEnumerator newLerp()
        {
            yield return lerp = StartCoroutine(onClick());
        }


        IEnumerator onClick()
        {
            float t = 0;
            while (t < 1)
            {
                time+= Time.deltaTime;
                if (time > 1)
                {
                    time = 0;
                    
                }
                transform.position = Vector2.Lerp(transform.position, (Vector3)movement, time);
                yield return null;
            }


        }
    }

    public void onPoint(InputAction.CallbackContext context)
    {
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }
}
