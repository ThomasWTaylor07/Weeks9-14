using JetBrains.Annotations;
using UnityEngine;

public class HazardMovement6 : MonoBehaviour
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
        speed = Random.Range(2f, 6f) * Time.deltaTime;
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
