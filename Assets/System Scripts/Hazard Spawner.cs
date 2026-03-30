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

    public GameObject hazard2;
    public GameObject spawnedHazard2;
    public UpdatedHazardCollision UHC2;
    public List<GameObject> h2;
    public float t2;
    public SpriteRenderer player2;

    public GameObject hazard3;
    public GameObject spawnedHazard3;
    public UpdatedHazardCollision UHC3;
    public List<GameObject> h3;
    public float t3;
    public SpriteRenderer player3;

    public GameObject hazard4;
    public GameObject spawnedHazard4;
    public UpdatedHazardCollision UHC4;
    public List<GameObject> h4;
    public float t4;
    public SpriteRenderer player4;



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
        if (t1 >= 10)
        {
            spawnedHazard1 = Instantiate(hazard1);
            UpdatedHazardCollision UHC1 = spawnedHazard1.GetComponent<UpdatedHazardCollision>();

            h1.Add(spawnedHazard1);


            t1 = 0;
        }
        if (t2 >= 4)
        {
            spawnedHazard2 = Instantiate(hazard2);
            UpdatedHazardCollision UCH2 = spawnedHazard2.GetComponent<UpdatedHazardCollision>();
            h2.Add(spawnedHazard2);

            t2 = 0;
        }
        if (t3 >= 15)
        {
            spawnedHazard3 = Instantiate(hazard3);
            UpdatedHazardCollision UCH3 = spawnedHazard3.GetComponent<UpdatedHazardCollision>();
            h3.Add(spawnedHazard3);

            t3 = 0;
        }
        if (t4 >= 15)
        {
            spawnedHazard4 = Instantiate(hazard4);
            UpdatedHazardCollision UCH4 = spawnedHazard4.GetComponent<UpdatedHazardCollision>();
            h4.Add(spawnedHazard4);

            t4 = 0;
        }
        for (int i = 0; i < h1.Count; i++)
        {
            UpdatedHazardCollision UHCi = h1[i].GetComponent<UpdatedHazardCollision>();
            UHCi.player = player1;
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
            UCHii.player = player2;
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
            UCHiii.player = player3;
            if (UCHiii.destroy == true)
            {
                GameObject hazard3 = h3[iii];
                h3.Remove(hazard3);
                Destroy(hazard3);
            }
        }
        for (int iiii = 0; iiii < h4.Count; iiii++)
        {
            UpdatedHazardCollision UCHiiii = h4[iiii].GetComponent<UpdatedHazardCollision>();
            UCHiiii.player = player4;
            if (UCHiiii.destroy == true)
            {

                GameObject hazard4 = h4[iiii];
                h4.Remove(hazard4);
                Destroy(hazard4);
            }
        }
    }
}