using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public SpriteRenderer mySpriteRenderer;
    void Update()
    {
        ProcessInputs();
    }
    void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal1");
        float moveY = Input.GetAxisRaw("Vertical1");
        if (moveX < 0)
        {
            mySpriteRenderer.flipX = true;
        }
        if (moveX > 0)
        {
            mySpriteRenderer.flipX = false;
        }
        moveDirection = new Vector2(moveX, moveY).normalized;

    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}


