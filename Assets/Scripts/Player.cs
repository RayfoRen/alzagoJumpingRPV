using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movHor;
    [SerializeField] float speed = 5f;
    [SerializeField] bool isMoving = false;
    [SerializeField] float jumpForce = 3f; 

    Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movHor = Input.GetAxisRaw("Horizontal");
        isMoving = (movHor != 0f);

        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            jump(); 
        } 
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(movHor * speed, rb.velocity.y);    
    }
    void jump() 
    { 
        rb.velocity = Vector2.up * jumpForce; 
    } 
}