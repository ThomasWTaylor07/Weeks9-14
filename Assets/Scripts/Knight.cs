using JetBrains.Annotations;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip Clip1;
    public AudioClip Clip2;
    public AudioClip Clip3;
    public AudioClip Clip4;
    public float clipValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void footStep()
    {
        clipValue = Random.Range(1, 5);

        if (clipValue == 1)
        {
            AudioSource.clip = Clip1;
            AudioSource.Play();
        }
        if (clipValue == 2)
        {
            AudioSource.clip = Clip2;
            AudioSource.Play();
        }
        if (clipValue == 3)
        {
           AudioSource.clip = Clip3;
            AudioSource.Play();
        }
        if (clipValue == 4)
        {
            AudioSource.clip = Clip4;
            AudioSource.Play();
        }
        Debug.Log("Step!");
    }
}
