using NUnit.Framework;
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
    public float t;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 2)
        {
            spawnedHazard1 = Instantiate(hazard1);
             UHC1 = spawnedHazard1.GetComponent<UpdatedHazardCollision>();
            h1.Add(spawnedHazard1);
           

            t = 0;
        }
        for (int i = 0; i < h1.Count; i++)
        {
            UHC1 = h1[i].GetComponent<UpdatedHazardCollision>();




        }
    }
}
