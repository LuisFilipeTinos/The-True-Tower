using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    float rotationX = 0;
    float rotationY = 0;
    float rotationZ = 0;

    float maxAngleX = 1;
    float maxAngleY = 1;
    float maxAngleZ = 1;

    float intensity = 0;

    float growthIntensity = 1;
    float decayIntensity = 1;

   

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey("f"))
        {
            
            intensity += growthIntensity  * Time.deltaTime;
        }
        else
        {
            intensity -= decayIntensity  * Time.deltaTime;
        }

        Shake();


    }

  

    
    private void Shake()
    {
       

        intensity = Mathf.Clamp(intensity, 0, 1);

        var intensityQuad = intensity * intensity;

       
        rotationX = intensityQuad * maxAngleX * Random.Range(-1, 1);
        
        transform.rotation = Quaternion.Euler(rotationX, 0, rotationZ);
    }
}
