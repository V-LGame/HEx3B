using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public SpriteRenderer mySpriteRenderer;
    //* Updates every frame.
    void Update()
    {
        ProcessInputs();
    }
    //* Updates every fixed amount of frames.
    void FixedUpdate()
    {
        Move();
    }
    //* Calculating the changes for the position and swaps the image of the players image by X axis respectivly.
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY= Input.GetAxisRaw("Vertical");
        if (moveX < 0)
        {
            mySpriteRenderer.flipX = true;
        }
        if (moveX > 0)
        {
            mySpriteRenderer.flipX = false;
        }
        //* (.normalized) was added so the movement in 2 axis simultaneously wont double the speed . 
        moveDirection = new Vector2(moveX, moveY).normalized;
        
    }
    //*Calculates the velocity of the the player using its position and Unity added speed.
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}


