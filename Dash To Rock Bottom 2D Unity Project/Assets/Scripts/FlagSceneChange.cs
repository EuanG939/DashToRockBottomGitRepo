using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagSceneChange : MonoBehaviour
{
    //Variable that allows the player to define whihc level should be loaded
    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //Debug.Log("Object hit the flag");

       //Change the current scene if the player collides with the trigger
        if (otherCollider.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }

        
    }
}
