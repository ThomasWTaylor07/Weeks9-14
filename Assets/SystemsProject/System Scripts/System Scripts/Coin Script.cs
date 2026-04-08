using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //Initializes a variable that gets access to the player objects sprite renderer so that it can recognize whenever the coins are within the bounds of the players sprite renderer
    public SpriteRenderer player;
    //Initializes a float that gets used to determine the objects x position
    public float xPos;
    //Initializes a float that gets used to determine the objects y position
    public float yPos;
    //Initializes a boolean that gets set to true whenever the coins are within the playesr sprite renderer so that the coin can be destroyed by the coin spawner script
    public bool collected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the coins x position variable to a random value so that when it's instantiated, it appears in a random x position
        xPos = Random.Range(-8, 8);
        //Sets the coins y position variable to a random value so that when it's instantiated, it appears in a random x position
        yPos = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //Assigns a new Vector2 to the objects transform that will take in values and use them to change where the coins are on screen
        Vector2 newPos = transform.position;
        //Sets the values of newPos to the xPos and yPos variables so that the objects transform can change the objects position using them
        newPos.x = xPos;
        newPos.y = yPos;
        //Assigns the obejcts transform to newPos so that it can take its values and use them to change the objects position
        transform.position = newPos;
        //Creates an if statement so that whenever a coin is within the players sprite renderer, something happens so it can be collected
        if (player.bounds.Contains(transform.position))
        {
        //A boolean is set to true to show that a coin has been collected which is used by the coin spawner script to see when a coin should be destroyed
            collected = true;
        }
    }
}
