using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public MeshRenderer renderer;
    public float speed = 5f;
    public bool isStoping = false;
    public bool isUp = false;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        renderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);


        if (Input.GetKey("e") || isStoping == true)
        {
            isStoping = true;
          
            StopElevator(speed);
         
        }
        
        if (Input.GetKey("r") || isUp == true)
        {
            isUp = true;
          
            StartElevator(speed);
        }

       
       
    }


    void StopElevator(float speedAmount)
    {
      
        renderer.material.mainTextureOffset -= 
            new Vector2(0, renderer.material.mainTextureOffset.y * (speedAmount * 0.2f) * Time.deltaTime);
  
    }

    void StartElevator(float speedAmount)
    {
        renderer.material.mainTextureOffset +=
            new Vector2(0, renderer.material.mainTextureOffset.y * (speedAmount * 0.2f) * Time.deltaTime);
    }



}
