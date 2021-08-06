using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{

    private float vel = 2.5f;

    void Start()
    {
        
    }

    void Update()
    {
        /**
        //Aperta e solta ativa, mesmo que fique segurando não faz nada.
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }
        //Aperta ativa, exemplo de onde você precisa ficar apertando a tecla.
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
        }
        //Aperta e segura ativado, Jogo de nave aperta e segura fica disparando.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, vel * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -vel * Time.deltaTime, 0));
        }
        */

        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector2(h * Time.deltaTime, v * Time.deltaTime));
    }
}
