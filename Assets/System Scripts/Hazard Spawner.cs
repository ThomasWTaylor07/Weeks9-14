using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class HazardSpawner : MonoBehaviour
{
    public GameObject hazard1;
    public GameObject spawnedHazard1;
    public UpdatedHazardCollision UHC1;
    public List<GameObject> h1;
    public float t1;
    public SpriteRenderer player1;
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
        t1 += Time.deltaTime;
        t2 += Time.deltaTime;
        t3 += Time.deltaTime;
        t4 += Time.deltaTime;
        t5 += Time.deltaTime;
        t6 += Time.deltaTime;
        t7 += Time.deltaTime;
        t8 += Time.deltaTime;
        t9 += Time.deltaTime;
        if (t1 >= 6)
        {
            spawnedHazard1 = Instantiate(hazard1);
            UpdatedHazardCollision UHC1 = spawnedHazard1.GetComponent<UpdatedHazardCollision>();

            h1.Add(spawnedHazard1);


            t1 = 0;
        }
        if (t2 >= 15)
        {
          
            spawnedHazard2 = Instantiate(hazard2);
            UpdatedHazardCollision UCH2 = spawnedHazard2.GetComponent<UpdatedHazardCollision>();
            h2.Add(spawnedHazard2);

            t2 = 0;
        }
        if (t3 >= 35)
        {
           
            spawnedHazard3 = Instantiate(hazard3);
            UpdatedHazardCollision UCH3 = spawnedHazard3.GetComponent<UpdatedHazardCollision>();
            h3.Add(spawnedHazard3);

            t3 = 0;
        }
        if (t4 >= 8)
        {
            
            spawnedHazard4 = Instantiate(hazard4);
            UpdatedHazardCollision UCH4 = spawnedHazard4.GetComponent<UpdatedHazardCollision>();
            h4.Add(spawnedHazard4);

            t4 = 0;
        }

        if (t5 >= 30)
        {
            
            spawnedHazard5 = Instantiate(hazard5);
            UpdatedHazardCollision UCH5 = spawnedHazard5.GetComponent<UpdatedHazardCollision>();
            h5.Add(spawnedHazard5);

            t5 = 0;
        }
        if (t6 >= 14)
        {
            
            spawnedHazard6 = Instantiate(hazard6);
            UpdatedHazardCollision UCH6 = spawnedHazard6.GetComponent<UpdatedHazardCollision>();
            h6.Add(spawnedHazard6);

            t6 = 0;
        }

        if (t7 >= 18)
        {
            
            spawnedHazard7 = Instantiate(hazard7);
            UpdatedHazardCollision UCH7 = spawnedHazard7.GetComponent<UpdatedHazardCollision>();
            h7.Add(spawnedHazard7);

            t7 = 0;
        }

        if (t8 >= 45)
        {
            
            spawnedHazard8 = Instantiate(hazard8);
            UpdatedHazardCollision UCH8 = spawnedHazard8.GetComponent<UpdatedHazardCollision>();
            h8.Add(spawnedHazard8);

            t8 = 0;
        }
        if (t9 >= 60)
        {
            spawnedHazard9 = Instantiate(hazard9);
            UpdatedHazardCollision UCH9 = spawnedHazard9.GetComponent<UpdatedHazardCollision>();
            h9.Add(spawnedHazard9);

            t9 = 0;
        }
        for (int i = 0; i < h1.Count; i++)
        {
            UpdatedHazardCollision UHCi = h1[i].GetComponent<UpdatedHazardCollision>();
            UHCi.player = player1;
            UHCi.gameManager = gm;
            if (UHCi.destroy == true)
            {

                GameObject hazard = h1[i];

                h1.Remove(hazard);

                Destroy(hazard);




            }
        }
        for (int ii = 0; ii < h2.Count; ii++)
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
        for (int iii = 0; iii < h3.Count; iii++)
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
        for (int iv = 0; iv < h4.Count; iv++)
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
        for (int v = 0; v < h5.Count; v++)
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
        for (int vi = 0; vi < h6.Count; vi++)
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
        for (int vii = 0; vii < h7.Count; vii++)
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
        for (int viii = 0; viii < h8.Count; viii++)
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
        for (int ix = 0; ix < h9.Count; ix++)
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
