using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRotate : MonoBehaviour
{
   
    //Variables to define the player and the flip state
    public Transform player;

    public bool isFlipped = false;

    public void LookAtPlayer()
    {
       //This flips the boss around on the z to look at the player
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

       //These if statements flip the boss around depending on where the player is
        
        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }
}
