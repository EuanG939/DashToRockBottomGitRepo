using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Variables to define the weapon's fire point and the prefab for the projectile
    public Transform firePoint;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
       //If the player presses the 'K' key, they will shoot
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        //This is the shooting logic
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        
    }
}
