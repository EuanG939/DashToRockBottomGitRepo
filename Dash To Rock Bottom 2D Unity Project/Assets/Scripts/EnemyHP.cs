using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    //Variables to define the enemy's health and their death effect
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        //Deal damage to the enemy if hit
        health -= damage;

        if (health <=0)
        {
            Die();
        }
    }

    void Die ()
    {
       //Kill the enemy, play a death effect
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

      
}
