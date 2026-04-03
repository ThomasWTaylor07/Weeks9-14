using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI UIText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(score);
        UIText.text = score.ToString();
    }
}
