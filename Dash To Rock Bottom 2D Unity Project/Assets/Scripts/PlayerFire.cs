using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //Unity editor variables
    public GameObject projectilePrefab;
    public GameObject ProjectileExit;
    public Vector2 projectileVelocity;
    public float delay;
    private float startTime;
    

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

            //play firing animation
            //delcare variable to hold aniamtion on the player
            Animator playerAnimator;
            //get the animation attached to the player
            playerAnimator = GetComponent<Animator>();
            //use the animator component to trigger an animation chnage for attacking
            playerAnimator.SetTrigger("attack");


    }

   


        void Update()
        {
            float endTime;
            endTime = startTime + delay;



            //When the 'K' key is pressed, the projectile will fire
            if (Input.GetButtonDown("Fire1"))
            {

                if (Time.time >= endTime)
                {
                    FireProjectile();
                }
            }


        }

    
}
