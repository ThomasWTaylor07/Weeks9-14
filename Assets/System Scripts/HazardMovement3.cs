using UnityEditor.Timeline;
using UnityEngine;

public class HazardMovement3 : MonoBehaviour
{
    //Initializes a float that acts as the Y position the object spawns at when instantiated
    public float yPos;
    //Initializes a float variable that moves the object by getting added to it's transform
    public float speed;
    //Gets access to an audio source so the hazard can play a sound when instantiated and when its collided with the player
    public AudioSource source;
    //Gets access to an audio clip that is meant to be played whenever the object first appears in the scene
    public AudioClip spawn;
    //Gets access to another audio clip that will be played when a Unity Event is invoked when the player and hazard collide
    public AudioClip collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the value of the float to a random position along the Y axis so that it can be at that point when instantiated
        yPos = Random.Range(-5, 5);
        //Gives the audio source access to the spawn sound so it can play when instantiated
        source.clip = spawn;
        //Plays the audio clip so that the player can hear when a prefab has been instantiated
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Multiplies the value of the speed varibale by delta time so that the object can move at a consistent rate
        speed = 10 * Time.deltaTime;
        //Assigns and initializes a Vector2 to the objects transform so that it can get values and update the transform using them
        Vector2 newPos = transform.position;
        //Sets the Y value of newPos to yPos so that it gets placed at that point on the Y axis
        newPos.y = yPos;
        //Subtracts the X value of newPos by speed so that the object can move left across the screen
        newPos.x -= speed;
        //Reassigns the transform to newPos so that the object can use its values to get a random X position and move in the scene
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
