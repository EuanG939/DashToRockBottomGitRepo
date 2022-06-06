using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   public void LoadTargetScene(string sceneToLoad)
    {
       //This changes the current scene to the player defined one
        SceneManager.LoadScene(sceneToLoad);
    }
}
