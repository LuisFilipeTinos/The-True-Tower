using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float resizeAmount = -.5f;
    public bool isMovingLeft = false;
    public bool isMovingRight = false;


    private void FixedUpdate()
    {
        if (Input.GetKey("q") || isMovingLeft)
        {
            isMovingLeft = true;
            Door(resizeAmount);
        }
        else if (Input.GetKey("w") || isMovingRight)
        {
            isMovingRight = true;
            Door(-resizeAmount);

        }
    }

    private void Door(float amount)
    {
        if (isMovingLeft == true || isMovingRight == true)
        {
            transform.localScale = new Vector3((transform.localScale.x + amount * Time.deltaTime), transform.localScale.y, transform.localScale.z);
            transform.position = new Vector3((transform.position.x + (amount / 2f) * Time.deltaTime), transform.position.y, transform.position.z);

            if (transform.localScale.x <= 0)
            {
                isMovingLeft = false;
               
            }

            if (transform.localScale.x >= 3.9688f)
            {
                isMovingRight = false;
            }
           
        }
    }

}

