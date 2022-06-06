using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    //Variables to determine if the game is paused and to define the pause menu UI
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        //Checks if the game is already paused when the pause button is pressed
        //if it is, resume the game
        //if it isn't, pause the game
        if (Input.GetButtonDown("Pause"))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        //Remove the UI overlay for the pause menu
        pauseMenuUI.SetActive(false);
        //Resume time as normal
        Time.timeScale = 1f;
       //Set the pause state to false
        GameIsPaused = false;
    }

    void Pause()
    {
        //Enable the UI overlay for the pause menu
        pauseMenuUI.SetActive(true);
        //Pause time
        Time.timeScale = 0f;
        //Set the pause state to true
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        //resume time
        Time.timeScale = 1f;
        //Load the main menu
        SceneManager.LoadScene("MainMenu");
    }

    

}
