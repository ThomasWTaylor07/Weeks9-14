using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class UpdatedHazardCollision : MonoBehaviour
{
    public Transform player;
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
        if (hazard.bounds.Contains(player.transform.position))
        {
           
            if (Collision == true)
            {
                onCollision.Invoke();
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
     
    }
}

