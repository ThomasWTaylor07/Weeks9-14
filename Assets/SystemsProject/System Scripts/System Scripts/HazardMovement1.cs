using UnityEngine;

public class HazardMovement1 : MonoBehaviour
{
    //Initializes a float varible that will move the object by being added to the objects transform
    public float speed;
    //Initializes a float that becomes the x position that the object spawns at when it gets instantiated
    public float xPos;
    //Gets access to an audio source that plays sound when the object is instantiated or a Unity Event is invoked
    public AudioSource source;
    //Gets an audio clip that plays in start so that it plays a sound whenever it's instantiated
    public AudioClip spawn;
    //Gets an audio clip that plays whenever a Unity Event is invoked to show that the player and a hazard have collided
    public AudioClip collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the value of the float to a random position along the x axis so that it can be positioned there when instantiated
        xPos = Random.Range(-8, 8);
        //Puts the spawn clip into the audio source so that it can be played when instaniated
        source.clip = spawn;
        //Plays the spawn clip from the audio source to tell the player that it has been instantiated
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the value of the speed varibale multipled by delta time so that the object can move at a consistent rate
        speed = 2 * Time.deltaTime;
      //Assigns and initializes a new Vector2 to the objects transform so that it can get values and update the transform with them
        Vector2 newPos = transform.position;
      //Subtracts the y value of newPos by speed so that the object can move down screen
        newPos.y -= speed;
      //Sets the x value of newPos to the value of xPos so that it gets put at a random point on the X axis
        newPos.x = xPos;
  //Reassigns the transform to newPos so that the object uses its values to go to at a random x position and moves down the screen
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
