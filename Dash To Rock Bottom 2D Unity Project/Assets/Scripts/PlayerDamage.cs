using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    
    //condition  - when the projectile hits a certain object type (enemy)
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //Check if the object that was collided with has the correct tag (Enemy)
        if(otherCollider.CompareTag("Enemy") == true)
        {
            //perform the action
            KillEnemy(otherCollider.gameObject);

            Destroy(gameObject);
        }


    }

    
    //action - destory an object (enemy)
    public void KillEnemy(GameObject enemy)
    {
        Destroy(enemy);
    }
}
