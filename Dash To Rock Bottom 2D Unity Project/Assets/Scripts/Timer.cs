using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    //Variables to define the starting time value, the time's text display, the game over sceen and the should reset state
    public float timeValue = 240;
    public Text timeText;
    public string gameOverScene;
    public bool shouldReset = false;


    void Start()
    {
        //If checked to true, reset the time back to it's original value
        if (shouldReset == true)
        {
            DisplayTime(timeValue);
        }

        
    }
    
    
    // Update is called once per frame
    void Update()
    {
        //Decrease time each second from the starting value down to 0
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);

        //If time reaches 0, switch the scene to the corresponding game over scene
        if (timeValue <= 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }


    void DisplayTime(float timeToDisplay)
    {
        //If the time goes below 0, set it back to 0 to avoid going into negative numbers
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else if(timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //Set the display format to minutes and seconds
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
