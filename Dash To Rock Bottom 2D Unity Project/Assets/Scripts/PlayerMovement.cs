using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables to define the player's movement speed and how high they can jump
    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;
    
    private void Start()
    {
       //References the player's rigidbody2D component 
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       //if the player presses either the 'A' or 'S' key, they will move left/right accordingly
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //If the player presses the 'J' key, the will jump
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    
    
    }


}
