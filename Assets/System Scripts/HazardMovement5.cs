using Unity.VisualScripting;
using UnityEngine;

public class HazardMovement5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Initializes a float variable that moves the object by getting added to it's transform
    public float speed;
    //Initializes a float that acts as the X position the object spawns at when instantiated
    public float xPos;
    //Gets access to an audio source so the hazard can play a sound when instantiated and when it collided with the player
    public AudioSource source;
    //Gets access to an audio clip that is meant to be played whenever the object first appears in the scene
    public AudioClip spawn;
    //Gets access to another audio clip that will be played when a Unity Event is invoked when the player and hazard collide
    public AudioClip collision;
    void Start()
    {
        //Sets the value of the float to a random value along the X axis so that it can be at that point when instantiate
        xPos = Random.Range(-8, 8);
        //Gives the audio source access to the spawn sound so it can play when instantiated
        source.clip = spawn;
        //Plays the audio clip so that the player can hear when a prefab has been instantiated
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets speed to a random value multiplied by detlta time so that it moves at a diffrent speed each time its instantiated
        speed = Random.Range(2f, 8f) * Time.deltaTime;
        //Assigns and initializes a Vector2 to the objects transform so that it can get values and update the transform using them
        Vector2 newPos = transform.position;
        //Sets the X value of newPos to xPos so that it gets placed at that point on the X axis
        newPos.x = xPos;
        //Subtracts the Y value of newPos by speed so that the object can move down the screen at a random speed
        newPos.y -= speed;
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
