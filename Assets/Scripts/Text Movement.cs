using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    public Transform text;
    public GameManager manager;
    public Coroutine Move;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (manager.score == 0)
        {
            Move = StartCoroutine(StartMoving());

        }

        else if (manager.score >= 1)
        {
            {
                if (Move != null)
                {
                    StopCoroutine(StartMoving());
                }
            }
        }


        IEnumerator StartMoving()
        {
            yield return StartCoroutine(MoveText());


        }

        IEnumerator MoveText()
        {
            float t = 0;
            text.transform.localScale = Vector3.zero;

            while (t < 1)
            {
                t += Time.deltaTime;


                Vector3 newScale = text.transform.localScale;
                newScale = Vector3.one * t;

                text.transform.localScale = newScale;
                yield return null;
            }
        }
    }
}


   

