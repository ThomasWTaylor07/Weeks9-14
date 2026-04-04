using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI UIText;
    public UnityEvent on0;
    public UnityEvent on1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        UIText.text = score.ToString();

        if (score == 0)
        {
            on0.Invoke();
        }
        if (score == 1)
        {
            on1.Invoke();
        }
    }
}
