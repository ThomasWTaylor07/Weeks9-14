using UnityEngine;

public class HazardMovement4 : MonoBehaviour
{
    //Gets access to an audio source so the hazard can play a sound when instantiated and when it collided with the player
    public AudioSource source;
    //Gets access to an audio clip that is meant to be played whenever the object first appears in the scene
    public AudioClip spawn;
    //Gets access to another audio clip that will be played when a Unity Event is invoked when the player and hazard collide
    public AudioClip collision;
    //Initializes a float variable that moves the object by getting added to it's transform
    public float speed;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Gives the audio source access to the spawn sound so it can play when instantiated
        source.clip = spawn;
        //Plays the audio clip so that the player can hear when a prefab has been instantiated
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Multiplies the value of the speed varibale by delta time so that the object can move at a consistent rate
        speed = 4 * Time.deltaTime;
 //Takes the objets transform and inrements it by it's up transform and speed variable so that it can move forward with a rotation
        transform.position += transform.up * speed; 
    }
    //This function happens whenever the onCollision Unity Event is invoked so that there is an indication of a collision happening
    public void playSound()
    {
        //Changes the clip from within the hazards audio source so that it can play a sound that indicates a collision
        source.clip = collision;
        //The audio source plays the clip its been given to show that a collision has happeneds
        source.Play();
    }
}
