using UnityEngine;

public class HazardMovement1 : MonoBehaviour
{
    public float speed = 0.000001f;
    public float xPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xPos = Random.Range(-8, 8);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.y -= speed;
        newPos.x = xPos;
        transform.position = newPos;
    }
}
