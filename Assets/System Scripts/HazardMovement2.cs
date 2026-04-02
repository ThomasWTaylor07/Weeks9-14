using Unity.VisualScripting;
using UnityEngine;

public class HazardMovement2 : MonoBehaviour
{
    public float speed;
    public float yPos;
    public AudioSource source;
    public AudioClip spawn;
    public AudioClip collision;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yPos = Random.Range(-5, 5);
        speed += 6f;
        source.clip = spawn;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
     
        Vector2 newPos = transform.position;
        newPos.y = yPos;
        newPos.x += speed * Time.deltaTime;
        transform.position = newPos;
    }
    public void playSound()
    {
        source.clip = collision;
        source.Play();
    }
}
