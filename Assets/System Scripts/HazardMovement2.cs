using Unity.VisualScripting;
using UnityEngine;

public class HazardMovement2 : MonoBehaviour
{
    //Initializes a float variable that moves the object by getting added to the objects transform
    public float speed;
    //Initializes a float that acts as the Y position that the object spawns at when instantiated
    public float yPos;
    //Gets access to an audio source so the hazard can play a sound when instantiated and when its collided with the player
    public AudioSource source;
    //Gets access to an audio clip that is meant to be played whenever the object first appears in the scene
    public AudioClip spawn;
    //Gets access to another audio clip that will be played when a Unity Event is invoked when the player and hazard collide 
    public AudioClip collision;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the value of the float to a random position along the Y axis so that it can be positioned there when instantiate
        yPos = Random.Range(-5, 5);
        //Gives the audio source access to the spawn sound so it can play when instantiated
        source.clip = spawn;
        //Plays the accessed audio clip so that the player can hear when a prefab has been instantiated
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Multiplies the value of the speed varibale by delta time so that the object can move at a consistent rate
        speed += 4 * Time.deltaTime;
      //Assigns and initializes a Vector2 to the objects transform so that it can get values and update the transform using them
        Vector2 newPos = transform.position;
        //Sets the Y value of newPos to xPos so that it gets placed at that point on the Y axis
        newPos.y = yPos;
        //Increments the X value of newPos by speed so that the object can move across the screen from left to right
        newPos.x += speed * Time.deltaTime;
//Reassigns the transform to newPos so that the object uses its values to go to at a random x position and moves from left to right
        transform.position = newPos;
    }
//This function happens whenever the onCollision Unity Event is invoked so that there is an indication of a collision happening
    public void playSound()
    {
        //Changes the clip from within the hazards audio source so that it can play a sound that indicates a collision
        source.clip = collision;
        //The audio source plays the clip its been given to show that a collision has happened
        source.Play();
    }
}
