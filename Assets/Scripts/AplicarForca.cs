using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicarForca : MonoBehaviour
{

    public float forca = 500f;
    public Rigidbody2D bola;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //Informando para game que 
        if (this.gameObject.CompareTag("mario"))
        {
            //Objeto que vai receber a forca + o vector + em que direcao a forca vai ser aplicada + o tipo da forca
            if (Input.GetKeyDown(KeyCode.Space)) { bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse); }
        }
    }
}
