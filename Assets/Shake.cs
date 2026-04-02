using Unity.Cinemachine;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public CinemachineImpulseSource impulse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void shake()
    {
        impulse.GenerateImpulse();
    }
}
