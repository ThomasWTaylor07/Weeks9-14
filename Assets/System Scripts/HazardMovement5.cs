using Unity.VisualScripting;
using UnityEngine;

public class HazardMovement5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    public float xPos;
    public AudioSource source;
    public AudioClip spawn;
    public AudioClip collision;
    void Start()
    {
        
        xPos = Random.Range(-8, 8);
        source.clip = spawn;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(2f, 6f) * Time.deltaTime;
        Vector2 newPos = transform.position;
        newPos.x = xPos;
        newPos.y -= speed;
        transform.position = newPos;
    }
    public void playSound()
    {
        source.clip = collision;
        source.Play();
    }
}
