using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    GameObject groundCheck;

    Rigidbody2D rb2d;

    [SerializeField]
    float jumpSpeed = 3f;

    public bool isGrounded = true;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Physics2D.Linecast(transform.position, groundCheck.transform.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if(Input.GetKey("space") && isGrounded == true)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            
        }
    }
}
