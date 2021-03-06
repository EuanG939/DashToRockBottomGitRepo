using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    void Update()
    {

        //HorizontalMove is for getting left and right inputs which in this case is the keys 'A' and 'D'
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
       

        //get rigidbody that is needed for physics info
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //find out from rigidbody what the current horizontal speed is
        float currentSpeedH = ourRigidbody.velocity.x;

        //get animator component that is goimg to be used for setting the animations
        Animator ourAnimator = GetComponent<Animator>();

        //Tell animator what the speed is
        ourAnimator.SetFloat("speedH", currentSpeedH);

        //Used for getting the jump function, which is the 'Space' key
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        //Used for crouching, which is the 'S' key
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }

        //If the player releases the crouch key, the player will no longer be crouched, this is to prevent the character being permanently crouched
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    //If the player is crouched, the player cannot jump
    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
