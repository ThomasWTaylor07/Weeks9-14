using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
   
    public AudioSource SFX;
    public float speed = 5;
    public Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Used with stick
        //transform.position += (Vector3)movement * speed * Time.deltaTime;
        transform.position = movement;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
    public void onAttack(InputAction.CallbackContext context)
    {
        Debug.Log("Attack!" + context.phase);
        if (context.performed)
        {
            SFX.Play();
        }
    }
    public void OnPoint(InputAction.CallbackContext context)
    {
        //Same as Mouse.current.position.ReadValue()
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }
}
