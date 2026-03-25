using JetBrains.Annotations;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public AudioSource AudioSource;
   
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
        AudioSource.Play();
        Debug.Log("Step!");
    }
}
