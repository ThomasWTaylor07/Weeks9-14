using UnityEditor.Timeline;
using UnityEngine;

public class HazardMovement3 : MonoBehaviour
{
    public float yPos;
    public float speed;
    public AudioSource source;
    public AudioClip spawn;
    public AudioClip collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yPos = Random.Range(-5, 5);
        source.clip = spawn;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 10 * Time.deltaTime;
        Vector2 newPos = transform.position;
        newPos.y = yPos;
        newPos.x -= speed;
        transform.position = newPos;
    }
    public void playSound()
    {
        source.clip = collision;
        source.Play();
    }
}
