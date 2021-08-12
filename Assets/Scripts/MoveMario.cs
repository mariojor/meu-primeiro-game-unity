using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMario : MonoBehaviour
{

    public float vel = 2.5f;
    public int cont = 0;
    public GameObject efeitoCoin;
    public AudioClip coin;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-vel * Time.deltaTime, 0));
        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("moeda"))
        {
            Gerenciador.inst.PlayAudio(coin);
            cont++;
            Destroy(outro.gameObject); 
        }
    }
}
