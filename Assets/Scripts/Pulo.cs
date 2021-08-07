using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo : MonoBehaviour {

    public float forca = 500f;
    public Rigidbody2D mario;
    public bool liberaPulo = false;
    public int duplo = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (duplo > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                mario.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
                duplo--;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("piso"))
        {
            duplo = 2;
            //liberaPulo = true;
        }
    }
    //Para pulo duplo nao precisa disso
   /** private void OnCollisionExit2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("piso"))
        {
            liberaPulo = false;
        }
    }*/
}
