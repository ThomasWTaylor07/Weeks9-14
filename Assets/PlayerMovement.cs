using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6;
    public Vector2 playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPos = transform.position; 
        newPos += (Vector3)playerMovement * speed * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, -9, 9);
        newPos.y = Mathf.Clamp(newPos.y, -5, 5);
        transform.position = newPos;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerMovement = context.ReadValue<Vector2>();
    }
}
