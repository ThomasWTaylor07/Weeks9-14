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
    public UnityEvent onCollision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (hazard.bounds.Contains(player.transform.position) == true)
        {
           
            if (Collision == true)
            {
                onCollision.Invoke();
            }
            else
            {
                Collision = true;
               
                Debug.Log("We in");
            }
        }
        else
        {
            if (Collision == true)
            {
                Collision = false;
                Debug.Log("We out");
            }

            else
            {

            }
        }
     
    }
}

