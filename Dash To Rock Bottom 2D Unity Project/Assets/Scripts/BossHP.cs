using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour
{
    //Variables to define the boss's health, invulnerability and the winning trigger point
    
    public int health = 500;

    public bool isInvulnerable = false;

    public GameObject winningTrigger;

    void Start()
    {
       //When the game starts, do not allow the player to enter the winning trigger and win before the boss dies
        winningTrigger.SetActive(false);
    }
    
    
    public void TakeDamage(int damage)
    {
        //If the boss is transforming to enraged, block all damage
        if (isInvulnerable)
            return;
        
        //Otherwise, let the player deal damage
        health -= damage;

        //When the boss's health gets below 500, transform to the enraged state
        if (health <= 500)
        {
            GetComponent<Animator>().SetBool("IsEnraged", true);
        }

       //Kill the boss if health gets below 0
        if (health <= 0)
        {
            Die();
        }
    }

    //Kill the boss and enable thw winning trigger so the player can win
    void Die()
    {
        Destroy(gameObject);
        winningTrigger.SetActive(true);
    }
}
