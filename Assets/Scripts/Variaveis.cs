using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    public float vel = 0.1f;
    public Renderer quad;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 offSet = new Vector2(vel * Time.deltaTime, 0);

        quad.material.mainTextureOffset += offSet;

    }
}
