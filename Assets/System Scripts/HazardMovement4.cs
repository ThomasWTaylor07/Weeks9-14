using UnityEngine;

public class HazardMovement4 : MonoBehaviour
{
    public float speed = 0.01f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed; 
    }
}
