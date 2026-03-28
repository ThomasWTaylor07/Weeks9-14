using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class UpdatedHazardCollision : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer hazard;
    public bool Collision;
    public float time;
    public bool destroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (hazard.bounds.Contains(player.transform.position))
        {
            if (Collision == true)
            {
                Debug.Log("Eek");
            }
            else
            {
                Collision = true;
                
            }
        }
        else
        {
            if (Collision == true)
            {
                Collision = false;
            }

            else
            {

            }
        }
        if (time > 10)
        {
            destroy = true;
        }
    }
}

