using UnityEngine;
using UnityEngine.Events;

public class UpdatedHazardCollision : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer hazard;
    public bool Collision;
    public UnityEvent OnCollision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(player.transform.position))
        {
            if (Collision == true)
            {

            }
            else
            {
                Collision = true;
                OnCollision.Invoke();
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

