using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    Vector2 movement;
    Vector3 rotation;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += (Vector3)movement * speed * Time.deltaTime;
        transform.up += rotation * speed * Time.deltaTime;
    }
    public void onMove(InputAction.CallbackContext context)
    {
        movement = context.action.ReadValue<Vector2>();
    }
    public void onLook(InputAction.CallbackContext context) 
    {
        rotation = context.action.ReadValue<Vector3>();
        

        }
}
