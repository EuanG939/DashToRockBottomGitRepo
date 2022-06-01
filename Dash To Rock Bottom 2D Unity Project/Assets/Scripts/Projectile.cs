using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{


    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

  
    //This detects if the projectile has hit the enemy by comparing its tag
    //it then applies damage until it kills the enemy
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Enemy")) {
            EnemyHP enemy = hitInfo.GetComponent<EnemyHP>();
            if (enemy !=null)
            {
                enemy.EnemyTakeDamage(damage);
            }
            Destroy(gameObject);
        }

        //This detects if the projectile has hit the boss by comparing its tag
        //it then applies damage until it kills the boss

        if (hitInfo.CompareTag("Boss"))
        {
            BossHP boss = hitInfo.GetComponent<BossHP>();
            if (boss != null)
            {
                boss.TakeDamage(damage);
            }
            Destroy(gameObject);
        }


    }
}
