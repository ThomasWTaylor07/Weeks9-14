using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class UpdatedHazardCollision : MonoBehaviour
{
//Gives each prefab access to the playes sprite renderer so that it can check whether its within the players bounds
    public SpriteRenderer player;
//Initializes a boolean that gets accessed by the spawner script to see if a hazard is within the playesr sprite renderer
    public bool Collision = false;
//Initializes a time variable to create a timer variable to count down the time until the hazard needs to be destroyed by the spawner
    public float time;
//Initializes a bool that gets accessed by the spawner script to destroy whatever game object it is equal to true on
    public bool destroy;
//Creates a Unity Event that causes something to happen within multiple diffrent scripts when the player and hazard collide
    public UnityEvent onCollision;
    //Gets access to the gameManager so when the Unity Event is invoked, its variables can be changed
    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets destroy to false so that it can be set to true later on in the script
        destroy = false;
        //Sets the starting value of a timer that counts down unill it reaches 0 and makes destroy equal true
        time = 25;
    }

    // Update is called once per frame
    void Update()
    {
        //Counts the timer down so that it can reach 0 and make destroy equal true
        time -= 0.01f;
        //Checks if a hazard is within the players sprite renderer so if it is, a Unity Event can be invoked
        if (player.bounds.Contains(transform.position) == true)
        {



            if (Collision == true)
            {
          //If collision = true and the hazard is within the players bounds, do nothing because collision is already true
            }
            else
            {
                //If collision = false and the hazard is within the players bounds, this means that the player and hazard just collided
                //Set collision to true to show that the hazard just collided with the player
                Collision = true;
                //Invoke the Unity Event that calls functions when a collision occurs
                onCollision.Invoke();
                
            }
        }
        else
        {
            if (Collision == true)
            {
//If collision = true and the hazard isn't within the bounds, that means the hazard has left the bounds and a collision is no longer occuring, so collision = false
                Collision = false;
                
            }

            else
            {
//If collision = false and the hazard is not within the bounds, that means that collision = false is correct and as such nothing needs to change since no collision is occuring 
            }
        }
//Checks if the timer is less than 0 so that a variable can be changed when the timer is done
        if (time < 0)
        {
//Set destroy to equal true so that the spawner script knows when to destroy an instantiated hazard by looking at this boolean in the script
            destroy = true;


        }

       
    }
    //Creates a function that gets invoked from the onCollision Unity Event so that it happens everytime there is a collision
    public void setScore()
    {
        //The score is changed to 0 from within the GameManager script so that a coroutine can start and so that the player needs to pick up more coins
        gameManager.score = 0;
    }

}

