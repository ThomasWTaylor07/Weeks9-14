using UnityEngine;

public class HazardMovement3 : MonoBehaviour
{
    public float yPos;
    public float speed = 0.001f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yPos = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.001f;
        Vector2 newPos = transform.position;
        newPos.y = yPos;
        newPos.x -= speed;
        transform.position = newPos;
    }
}
