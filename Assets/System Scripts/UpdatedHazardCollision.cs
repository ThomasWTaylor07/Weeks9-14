using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class UpdatedHazardCollision : MonoBehaviour
{
    public SpriteRenderer player;
    
    public bool Collision = false;
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
       
        if (player.bounds.Contains(transform.position) == true)
        {

            
           
            if (Collision == true)
            {
                
            }
            else
            {
                Collision = true;
                onCollision.Invoke();
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

