using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class HazardSpawner : MonoBehaviour
{
//Each hazard has their own game object that gets taken from the inspector to be instantiated
    public GameObject hazard1;
//Each instantiated hazard gets put into a unique game object that then gets added to a list of that specific hazard
    public GameObject spawnedHazard1;
//Each hazard gets its own Updated Hazard Collision script so it can be used to reassign things and determine when to destroy an object
    public UpdatedHazardCollision UHC1;
//Each hazard is added to its own list of that specific hazard so that objects can be removed and things can be assigned easily
    public List<GameObject> h1;
//Each hazard has its own time variable that acts as a timer that will instantiate a prefab when its at the right time
    public float t1;
//The sprite renderer for the player in the scene is used to reassign it for each prefab so instaed of looking at the sprite renderer for the player prefab, its looking at the position of the actual player object
    public SpriteRenderer player1;
//The game manager script is also brough into the script to reassign it from the prefab version to the one in the scene so that the score can be updated accuratley
    public GameManager gm;
    
    

    public GameObject hazard2;
    public GameObject spawnedHazard2;
    public UpdatedHazardCollision UHC2;
    public List<GameObject> h2;
    public float t2;
  
    
    


    public GameObject hazard3;
    public GameObject spawnedHazard3;
    public UpdatedHazardCollision UHC3;
    public List<GameObject> h3;
    public float t3;
 



    public GameObject hazard4;
    public GameObject spawnedHazard4;
    public UpdatedHazardCollision UHC4;
    public List<GameObject> h4;
    public float t4;
    

  

    public GameObject hazard5;
    public GameObject spawnedHazard5;
    public UpdatedHazardCollision UHC5;
    public List<GameObject> h5;
    public float t5;


    

    public GameObject hazard6;
    public GameObject spawnedHazard6;
    public UpdatedHazardCollision UHC6;
    public List<GameObject> h6;
    public float t6;
   
 
   

    public GameObject hazard7;
    public GameObject spawnedHazard7;
    public UpdatedHazardCollision UHC7;
    public List<GameObject> h7;
    public float t7;
   

  

    public GameObject hazard8;
    public GameObject spawnedHazard8;
    public UpdatedHazardCollision UHC8;
    public List<GameObject> h8;
    public float t8;




    public GameObject hazard9;
    public GameObject spawnedHazard9;
    public UpdatedHazardCollision UHC9;
    public List<GameObject> h9;
    public float t9;
    
   



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //The time for every diffrent hazard is increased by delta time to ensure consistent timing for all of them
        t1 += Time.deltaTime;
        t2 += Time.deltaTime;
        t3 += Time.deltaTime;
        t4 += Time.deltaTime;
        t5 += Time.deltaTime;
        t6 += Time.deltaTime;
        t7 += Time.deltaTime;
        t8 += Time.deltaTime;
        t9 += Time.deltaTime;
 //Each prefab has its own maximum time until it gets instantiated, with an if statement used to determine if it has reached that time
        if (t1 >= 6)
        {
//Each hazards gets instantiated and turns into a game object that gets added to their own list of game objects
            spawnedHazard1 = Instantiate(hazard1);
//Each hazard has its own list of these game object which gets added to everytime a new one is created so that it can be destroyed and be given its collision script
            h1.Add(spawnedHazard1);

//When the max time is reached, the varible gets reset to 0 so that the timer can start again and a new prefab can be instantiated
            t1 = 0;
        }
        if (t2 >= 15)
        {
          
            spawnedHazard2 = Instantiate(hazard2);
            h2.Add(spawnedHazard2);

            t2 = 0;
        }
        if (t3 >= 35)
        {
           
            spawnedHazard3 = Instantiate(hazard3);
            
            h3.Add(spawnedHazard3);

            t3 = 0;
        }
        if (t4 >= 8)
        {
            
            spawnedHazard4 = Instantiate(hazard4);
            
            h4.Add(spawnedHazard4);

            t4 = 0;
        }

        if (t5 >= 30)
        {
            
            spawnedHazard5 = Instantiate(hazard5);
            
            h5.Add(spawnedHazard5);

            t5 = 0;
        }
        if (t6 >= 14)
        {
            
            spawnedHazard6 = Instantiate(hazard6);
            
            h6.Add(spawnedHazard6);

            t6 = 0;
        }

        if (t7 >= 18)
        {
            
            spawnedHazard7 = Instantiate(hazard7);
            
            h7.Add(spawnedHazard7);

            t7 = 0;
        }

        if (t8 >= 45)
        {
            
            spawnedHazard8 = Instantiate(hazard8);
            
            h8.Add(spawnedHazard8);

            t8 = 0;
        }
        if (t9 >= 60)
        {
            spawnedHazard9 = Instantiate(hazard9);
            
            h9.Add(spawnedHazard9);

            t9 = 0;
        }
//Each hazard list is accessed using a for loop that gets access to each of the hazards in the scene so they can be altered
        for (int i = h1.Count - 1; i >= 0; i--)
        {
//Each hazard in the scene gets access to the collsion script again so variables can be reassigned and so it can access their destroy boolean
            UpdatedHazardCollision UHCi = h1[i].GetComponent<UpdatedHazardCollision>();
//Each hazard reassigns the player prefab that's been assigned in their inspector to the player in the scene so that they get an accuarate player position
            UHCi.player = player1;
//Each hazard reassigns the GameManager prefab script from their inspector to the one in the scene so that setScore() can set the variable of the manager in the scene
            UHCi.gameManager = gm;
//Each hazard has an if statement that checks if any hazards in the list has their destroy boolean equal to true so that the object gets destroyed
            if (UHCi.destroy == true)
            {
//If a hazard's boolean is true, that specific object in the list gets turned into a game object so that it can be destroyed
                GameObject hazard = h1[i];
//The game object is than removed from the list so it doesn't try and get accessed by the script once destroyed
                h1.Remove(hazard);
//The object then gets destroyed, removing it from the scene so that there aren't too many hazards at one time
                Destroy(hazard);




            }
        }
        for (int ii = h2.Count - 1; ii >= 0; ii--)
        {
            UpdatedHazardCollision UCHii = h2[ii].GetComponent<UpdatedHazardCollision>();
            UCHii.player = player1;
            UCHii.gameManager = gm;
            if (UCHii.destroy == true)
            {
                GameObject hazard2 = h2[ii];
                h2.Remove(hazard2);
                Destroy(hazard2);
            }

        }
        for (int iii = h3.Count - 1; iii >= 0; iii--)
        {
            UpdatedHazardCollision UCHiii = h3[iii].GetComponent<UpdatedHazardCollision>();
            UCHiii.player = player1;
            UCHiii.gameManager = gm;
            if (UCHiii.destroy == true)
            {
                GameObject hazard3 = h3[iii];
                h3.Remove(hazard3);
                Destroy(hazard3);
            }
        }
        for (int iv = h4.Count - 1; iv >= 0; iv--)
        {
            UpdatedHazardCollision UCHiv = h4[iv].GetComponent<UpdatedHazardCollision>();
            UCHiv.player = player1;
            UCHiv.gameManager = gm;
            if (UCHiv.destroy == true)
            {
                GameObject hazard4 = h4[iv];
                h4.Remove(hazard4);
                Destroy(hazard4);
            }
        }
        for (int v = h5.Count - 1; v >= 0; v--)
        {
            UpdatedHazardCollision UCHv = h5[v].GetComponent<UpdatedHazardCollision>();
            UCHv.player = player1;
            UCHv.gameManager = gm;
            if (UCHv.destroy == true)
            {
                GameObject hazard5 = h5[v];
                h5.Remove(hazard5);
                Destroy(hazard5);
            }
        }
        for (int vi = h6.Count - 1; vi >= 0; vi--)
        {
            UpdatedHazardCollision UCHvi = h6[vi].GetComponent<UpdatedHazardCollision>();
            UCHvi.player = player1;
            UCHvi.gameManager = gm;
            if (UCHvi.destroy == true)
            {
                GameObject hazard6 = h6[vi];
                h6.Remove(hazard6);
                Destroy(hazard6);
            }
        }
        for (int vii = h7.Count - 1; vii >= 0;vii--)
        {
            UpdatedHazardCollision UCHvii = h7[vii].GetComponent<UpdatedHazardCollision>();
            UCHvii.player = player1;
            UCHvii.gameManager = gm;
            if (UCHvii.destroy == true)
            {
                GameObject hazard7 = h7[vii];
                h7.Remove(hazard7);
                Destroy(hazard7);
            }
        }
        for (int viii = h8.Count - 1; viii >= 0; viii--)
        {
            UpdatedHazardCollision UCHviii = h8[viii].GetComponent<UpdatedHazardCollision>();
            UCHviii.player = player1;
            UCHviii.gameManager = gm;
            if (UCHviii.destroy == true)
            {
                GameObject hazard8 = h8[viii];
                h8.Remove(hazard8);
                Destroy(hazard8);
            }
        }
        for (int ix = h9.Count - 1; ix >= 0; ix--)
        {
            UpdatedHazardCollision UCHix = h9[ix].GetComponent<UpdatedHazardCollision>();
            UCHix.player = player1;
            UCHix.gameManager = gm; 
            if (UCHix.destroy == true)
            {
                GameObject hazard9 = h9[ix];
                h9.Remove(hazard9);
                Destroy(hazard9);
            }
        }
    }
    }
