using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    //Allows the script to get access to the ghost prefab from the inspector so it can be instantiated and destroyed
    public GameObject coins;
    //Gives the script the sprite renderer of the player in the scene so that each prefab can recognize its sprite renderer
    public SpriteRenderer scenePlayer;
    //Gives the spawner access to the coin script so it can give it to each spawn coin and so it can check whether collided = true
    public CoinScript CS;
    //Initializes a game object that is meant to turn each instantiated coin into a game object that gets added to a list
    public GameObject spawnedCoins;
    //Initializes a list that is meant to store each spawnedCoins game object and destroy them when needed
    public List<GameObject> list;
    //Initializes a float that uses delta time to count up until a certain number is reached, acting as a timer for each instantiation
    public float t;
    //Gives the script access to the script within the GameManager object so that it's score value can be updated when a coin's destroyed
    public GameManager GM;
    //Links the script to an audio souce that will play a sound effect when the coin is destroyed
    public AudioSource AS;
    //Gives the script an audio clip to play within the linked audio source when a coin is destroyed
    public AudioClip collect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    //Increases a value of t by delta time to have an accurate timer that counts the time until the next instantiation
        t += Time.deltaTime;
    //An if statement checks whenever t has gone above a certain time as a way to instantiate a new prefab every 8 seconds
        if (t > 8)
        {
            //A coin prefab gets instantiated and gets converted into a game object that gets added to a list
            spawnedCoins = Instantiate(coins, transform.position, Quaternion.identity);
            //That game object gets added to a list which allows it to be destroyed and get the Coin Script
            list.Add(spawnedCoins);
            //Sets t back to 0 so that the 8 second timer can be started again and another prefab can be instantiated
            t = 0;
        }
        //This for loop grabs every coin in it's lost so it can change them individually
        for (int i = 0; i < list.Count; i++)
        {
            //Gives each coin in the list access to its script so that it can check for collisions
            CoinScript csi = list[i].GetComponent<CoinScript>();
            //Changes the player from the one in the coin prefabs inspector to the one in the scene so that it can get its accurate position and check its sprite renderer instead
            csi.player = scenePlayer;
            //Checks if the collected boolean within each of the coins prefabs is true to see whether it needs to be destroyed
            if(csi.collected == true)
            {
            //Sets the audio clip that will be played in the audio source to show that a coin has been collected
                AS.clip = collect;
            //Plays the audio clip in the audio source to show a coin has been collected
                AS.Play();
                //Gets the specific coin where collected = true and assigns it to a local game object
                GameObject coin = list[i];
                //The game object then gets removed from the list so it doesn't try and get accessed again
                list.Remove(coin);
                //The game object gets destroyed so that it is no longer on screen
                Destroy(coin);
                //Adds 1 to the score variable in the GameManager script
                GM.score += 1;
            }
        }
    }
}
