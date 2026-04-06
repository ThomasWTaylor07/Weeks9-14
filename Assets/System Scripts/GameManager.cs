using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
//Initializes a variable that counts how many coins have been collected in the scene without getting hit
    public float score;
    //Gets access to a Text Mesh in the UI so that it can assign it to show the value of the score float on screen
    public TextMeshProUGUI UIText;
     //Initializes a Unity Event that is meant to start a coroutiune within the text's script
    public UnityEvent on0;
    //Initializes a Unity Event that is meant to stop a coroutiune within the text's script
    public UnityEvent on1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Assigns the text within the text mesh to show a string version of the score variable so that it can be displayed on screen
        UIText.text = score.ToString();
        //Another if statement that checks if score is equal to 0 so it can invoke a Unity Event
        if (score == 0)
        {
        //The on0 Unity Event is invoked so that everytime the score is 0, a coroutine in another script can start
            on0.Invoke();
        }
        //Another if statement that checks if score is greater than 1 so it can invoke another Unity Event
        if (score > 0)
        {
            //The on0 Unity Event is invoked so that everytime the score is 1, a coroutine in another script gets stopped
            on1.Invoke();
        }
    }
}
