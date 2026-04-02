using UnityEngine;

public class HazardMovement1 : MonoBehaviour
{
    public float speed;
    public float xPos;
    public AudioSource source;
    public AudioClip spawn;
    public AudioClip collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xPos = Random.Range(-8, 8);
        source.clip = spawn;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        speed = 2 * Time.deltaTime;
        Vector2 newPos = transform.position;
        newPos.y -= speed;
        Debug.Log(Time.deltaTime * speed);
        newPos.x = xPos;
        transform.position = newPos;
    }
    public void playSound()
    {
        source.clip = collision;
        source.Play();
    }
}
