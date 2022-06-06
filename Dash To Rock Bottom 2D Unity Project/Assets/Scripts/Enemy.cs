using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
   //the enemy's health
    public int health = 100;

    

    public void EnemyTakeDamage (int damage)
    {
      //Deal damage to the enemy if hit
        health -= damage;

        if (health <=0)
        {
            EnemyDie();
        }
    }

    void EnemyDie ()
    {
        //Kill the enemy
        Destroy(gameObject);
    }

      
}
