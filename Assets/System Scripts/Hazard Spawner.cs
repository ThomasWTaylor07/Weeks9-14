using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HazardSpawner : MonoBehaviour
{
    public GameObject hazard1;
    public GameObject spawnedHazard1;
    public UpdatedHazardCollision UHC1;
    public List<GameObject> h1;
    public float t;
    public bool good;
    public UnityEvent OnCollision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        good = false;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 2)
        {
            spawnedHazard1 = Instantiate(hazard1);

            UpdatedHazardCollision UHC1 = spawnedHazard1.GetComponent<UpdatedHazardCollision>();
            h1.Add(spawnedHazard1);

            t = 0;
        }
        for (int i = 0; i < h1.Count; i++)
        {
            UpdatedHazardCollision UHC1i = h1[i].GetComponent<UpdatedHazardCollision>();

            if (UHC1i.Collision == true)
            {
                OnCollision.Invoke();
               
            }
            if(UHC1i.destroy == true)
            {
                GameObject hazard1 = h1[i];

                h1.Remove(hazard1);

                Destroy(hazard1);
            }
        }
    }
}
