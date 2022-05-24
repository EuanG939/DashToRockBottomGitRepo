using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EnemyFire : MonoBehaviour
{
    //Unity editor variables
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;
    public float delay;
    private float startTime;
    public float distanceForDecision;
    public Transform target;


    
    
    
    //Action - Fire a projectile
    public void FireProjectile()
    {

        //Clone projectile and fire it in a direction

        //Declare variable to hold the cloned object
        GameObject clonedProjectile;
        //Use instantiate to clone the project and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        //Position the projectile on the player
        clonedProjectile.transform.position = transform.position;

        //Declare a variable to hold the cloned object's rigidbody
        Rigidbody2D projectileRigidbody;
        //Get the rigidybody from our cloned projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        //Set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileVelocity;

        


    }




    void Update()
    {
        float endTime;
        endTime = startTime + delay;

        float distance = ((Vector2)target.position - (Vector2)transform.position).magnitude;

        //if closer to target than minimum distance
        if (distance <= distanceForDecision)
        {
            

            if (Time.time >= endTime)
            {
                FireProjectile();

            }

        }

    }


}
