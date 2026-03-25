using UnityEngine;

public class SimpleMovementScript : MonoBehaviour
{
    public float speedX = 0.01f;
    public float speedY = 1;
    public AnimationCurve ac;
    public float t;
    public GameObject trail;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime / 2;
        if (t > 1)
        {


            t = 0;

        }


        Debug.Log(speedY * ac.Evaluate(t));
        Vector2 newPos = transform.position;

        newPos.x += 1 * Time.deltaTime;
        newPos.y = ac.Evaluate(t);
        transform.position = newPos;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x >= Screen.width + 100)
        {
            trail.SetActive(false);
            newPos.x = -12;
            transform.position = newPos;
            trail.SetActive(true);

        }

    }
}
