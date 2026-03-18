using System.Collections;
using System.Diagnostics;
using Unity.Collections;
using UnityEngine;

public class Grower : MonoBehaviour
{
    public Transform tree;
    public Transform apple;
    Coroutine doTheCoroutine;
    Coroutine growTheTreeCoroutine;
    Coroutine growTheAppleCoroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tree.localScale = Vector2.zero;
        apple.localScale = Vector2.zero;
    }

    public void StartTreeGrowing()
    {
        if (doTheCoroutine != null)
        {

            StopCoroutine(doTheCoroutine);
        }
        if (growTheAppleCoroutine != null)
        {
            StopCoroutine(growTheAppleCoroutine);
        }
        if (growTheTreeCoroutine != null)
        {
            StopCoroutine(growTheTreeCoroutine);
        }
        doTheCoroutine = StartCoroutine(DoTheGrowing());
      
    }
    IEnumerator DoTheGrowing()
    {
        yield return growTheTreeCoroutine = StartCoroutine(GrowTree());
        yield return growTheAppleCoroutine = StartCoroutine(GrowApple());
    }
IEnumerator GrowTree()
    {
        UnityEngine.Debug.Log("Start growing tree");
        tree.localScale = Vector2.zero;
        apple.localScale = Vector2.zero;
        float t = 0;
        while ( t < 1)
        {
            t += Time.deltaTime;
            tree.localScale = Vector2.one * t;
            yield return null;
         
        }
        UnityEngine.Debug.Log("Stop growing tree");

    }
    IEnumerator GrowApple()
    {
        UnityEngine.Debug.Log("Start growing apple");
        apple.localScale = Vector2.zero;
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            apple.localScale = Vector2.one * t;
            yield return null;
        }
        UnityEngine.Debug.Log("Stop growing apple");
    }

}
