using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health = 100;

    

    public void EnemyTakeDamage (int damage)
    {
        health -= damage;

        if (health <=0)
        {
            EnemyDie();
        }
    }

    void EnemyDie ()
    {
        
        Destroy(gameObject);
    }

      
}
