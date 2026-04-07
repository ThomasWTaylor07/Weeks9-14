using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    //Creates a new coroutine that starts the coroutine that moves the text on screen which gets stopped using Unity Events
    public Coroutine Move;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { 
   
               
            }
    //This public function starts a coroutine and is activated by a Unity Event being invoked
    public void movement()
    {
     //This starts the StartMoving coroutine which starts the couroutine that moves the text
        StartCoroutine(StartMoving());
    }

    public void stopMove()
    {
        //This checks if the Move coroutine isn't null, meaning it is curretly active, so when the score in greater than 1, they know that the coroutine needs to be stopped
        if (Move != null)
        {
            //Stops the coroutie that starts the Move coroutine that allows the text to move in the UI
            StopCoroutine(Move);
        }
    }
    
    //This coroutine is what starts and stops the MoveText coroutine from happening through Unity Events
    IEnumerator StartMoving()
        {
        //This is what allows the Move coroutine to start the text movement coroutine 
            yield return Move = StartCoroutine(MoveText());


        }

        IEnumerator MoveText()
        {
        //Sets a float that acts as a timer so that the movement happens in 1 second and sets it to 0 so each time the coroutine starts the timer also gets restarted
            float t = 0;
        //Sets the scale of the text to 0 so that it can grown back into view when the coroutine is started
            transform.localScale = Vector3.zero;
        //Creates a while statement that checks before t = 1 as that means the coroutine has lasted for 1 second and is supposed to end
            while (t < 1)
            {
            //Adds delta time to the value of t to create an accurate timer that will allow the while loop to end after 1 second
                t += Time.deltaTime;
            //Sets a Vector3 to the local scale of the object so that it can be changed based on the values given to it 
                Vector3 newScale = transform.localScale;
            //Assigns that variable the value of 1 * delta time so that it's value increases over the course of 1 second
                newScale = Vector3.one * t;
            //Assigns the local scale back to the Vector3 so that it's assigned values can change the text's size
                transform.localScale = newScale;
            //This yield return allows for the coroutine to check the script to see if it can happen again on the next frame or if it's stopped so that it doesn't repeat
                yield return null;
            }
        }
    }



   

