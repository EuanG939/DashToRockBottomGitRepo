using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup2 : MonoBehaviour
{
    //public variable
    public int pickupValue = 1;
    public GameObject Pickup2;

    //called by unity when this object overlaps
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check if score script is attached to the thing we bumped into
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            //we have a score script so the thing we bumped into is the player
            scoreScript.AddScore(pickupValue);

            //we should then delete this object so we don't infinitely add score
            Destroy(gameObject);

            //Change the pickup control state to 0, so that the item doesnt respawn upon a scene loading
            PickupControl.control.Pickup2state = 0;



        }
    }


    void Update()
    {
        if (PickupControl.control.Pickup2state == 0)
        {
           //Destory the pickup for the remainder of the game
            Destroy(Pickup2);
        }
    }

}