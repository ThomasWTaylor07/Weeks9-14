using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class PlayerMovement : MonoBehaviour
{
    //Sets a speed variable that will be used to allow the player to move across the screen whenever the input system gives a non 0 value
    public float speed = 6;
    //Creates a Vector3 that contains the value given to it by the Unity input system so that it can move the objects transform
    public Vector3 playerMovement;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Assigns a new Vector3 to the objeccts transform that will get assigned a new value and change the transform
        Vector3 newPos = transform.position; 
        //Sets the vector3 to the values given by the Unity input system multiplied by speed and delta time so that the players inputs can change the objects transform
        newPos += playerMovement * speed * Time.deltaTime;
        //Puts a clamp on the newPos x and y values by setting the minimum and maximum value they are allowed to be
        newPos.x = Mathf.Clamp(newPos.x, -9, 9);
        //This means that the object will never appear fully off screen
        newPos.y = Mathf.Clamp(newPos.y, -5, 5);
        //Assigns newPos back to the objects transform so that it can use the updated values given to newPos to move the object 
        transform.position = newPos;
    }
    //Creates a function with a paramater that gives us access to the value from the input system
    public void OnMove(InputAction.CallbackContext context)
    {
        {

            //The player movement variable gets assigned the value from the input system as a Vector2 so that player inputs can change its value and move the object
            playerMovement = context.ReadValue<Vector2>();
        }
    }
    
}
