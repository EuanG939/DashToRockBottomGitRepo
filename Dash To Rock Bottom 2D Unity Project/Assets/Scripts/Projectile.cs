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
