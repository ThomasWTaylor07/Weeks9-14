using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public SpriteRenderer player;
    public float xPos;
    public float yPos;
    public bool collected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xPos = Random.Range(-8, 8);
        yPos = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x = xPos;
        newPos.y = yPos;
        transform.position = newPos;
        if (player.bounds.Contains(transform.position))
        {
            collected = true;
        }
    }
}
