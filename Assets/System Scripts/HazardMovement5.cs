using Unity.VisualScripting;
using UnityEngine;

public class HazardMovement5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    public float xPos;
    void Start()
    {
        speed = Random.Range(0.01f, 1f);
        xPos = Random.Range(-8, 8);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x = xPos;
        newPos.y += speed;
    }
}
