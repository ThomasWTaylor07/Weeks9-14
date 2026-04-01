using Unity.VisualScripting;
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
    public AudioSource asource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroy = false;
        time = 20;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 0.01f;
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
        if (time < 0)
        {
            destroy = true;


        }
    }
    public void playSound()
    {
        asource.Play();
    }
}

