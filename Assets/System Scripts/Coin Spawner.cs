using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coins;
    public SpriteRenderer scenePlayer;
    public CoinScript CS;
    public GameObject spawnedCoins;
    public List<GameObject> list;
    public float t;
    public GameManager GM;
    public AudioSource AS;
    public AudioClip collect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 3)
        {
            spawnedCoins = Instantiate(coins, transform.position, Quaternion.identity);
            list.Add(spawnedCoins);
            t = 0;
        }

        for (int i = 0; i < list.Count; i++)
        {
            CoinScript csi = list[i].GetComponent<CoinScript>();
            csi.player = scenePlayer;
            if(csi.collected == true)
            {
                AS.clip = collect;
                AS.Play();
                GameObject coin = list[i];
                list.Remove(coin);
                Destroy(coin);
                GM.score += 1;
            }
        }
    }
}
