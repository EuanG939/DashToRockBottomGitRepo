using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarDisplay : MonoBehaviour
{
    // This will contain the slider components attached to this object
    // Slider = Variable is in the form of a slider component
    Slider healthBar;

    // This will be the Playerhealth component that we can ask for info on the player's health
    PlayerHealth player;


    // Start is called before the first frame update
    void Start()
    {
        //Getting the Slider component off this game object
        // (the one this script is attached to) and storing it in the healthBar variable
        healthBar = GetComponent <Slider>();

        //search the entire scene for the PlayerHealth component and store it in the player variable

        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //create temporary float variables so we can use float division
        float currentHealth = player.GetHealth();
        float maxHealth = player.startingHealth;

        //The slider value should be between 0 and 1, 0 being empty and 1 being full
        //We divide the current health by max health to get a number between 0 and 1
        healthBar.value = currentHealth / maxHealth;
    }
}
