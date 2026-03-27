using Unity.VisualScripting;
using UnityEngine;

public class HazardMovement2 : MonoBehaviour
{
    public float speed = 0.1f;
    public float yPos;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yPos = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.y = yPos;
        newPos.x += speed;
        transform.position = newPos;
    }
}
