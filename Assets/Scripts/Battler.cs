using System.Collections;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform space;
    public Coroutine doTheRotationCoroutine;
    public Coroutine doTheCoroutine;
    public AnimationCurve aC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void StartRotation()
    {
        if (doTheCoroutine != null)
        {
            StopCoroutine(doTheCoroutine);
        }

        if (doTheRotationCoroutine != null)
        {
            StopCoroutine(doTheRotationCoroutine);
        }

        doTheCoroutine = StartCoroutine(DoTheRotation());

        IEnumerator DoTheRotation()
        {
            yield return doTheRotationCoroutine = StartCoroutine(RotateObject());
        }
        IEnumerator RotateObject()
        {
            Debug.Log("Started Rotation");
           Vector3 newRotate = space.eulerAngles;
            float t = 0;
            float r = aC.Evaluate(t);
   
            while (t < 1)

            {
                t += Time.deltaTime;
                newRotate.z += 1 * t;

                yield return null;
                space.eulerAngles = newRotate;

            }
          
           
        }
    }
}
