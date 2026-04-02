using UnityEngine;

public class HazardMovement4 : MonoBehaviour
{
    public AudioSource source;
    public AudioClip spawn;
    public AudioClip collision;
    public float speed;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source.clip = spawn;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 4 * Time.deltaTime;
        transform.position += transform.up * speed; 
    }
    public void playSound()
    {
        source.clip = collision;
        source.Play();
    }
}
