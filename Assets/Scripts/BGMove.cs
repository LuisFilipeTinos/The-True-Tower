using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public MeshRenderer renderer;
    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}
