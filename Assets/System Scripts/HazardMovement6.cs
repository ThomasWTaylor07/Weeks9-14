using JetBrains.Annotations;
using UnityEngine;

public class HazardMovement6 : MonoBehaviour
{
    public float yPos;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yPos = Random.Range(-5, 5);
        speed = Random.Range(0.01f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
