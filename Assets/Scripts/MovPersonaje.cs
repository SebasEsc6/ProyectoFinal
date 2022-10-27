using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float velocidadInicial = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator player;
    public float x, y, VelocidadMovimiento;  

    void Start()
    {
        player = GetComponent<Animator>();   
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        VelocidadMovimiento = velocidadInicial;
        if (Input.GetKey(KeyCode.LeftShift)){
            VelocidadMovimiento = 10.0f;
            if(y>0)
            {
                player.SetBool("PuedoCorrer", true);
            }
            else
            {
                player.SetBool("PuedoCorrer", false);
            }
        }
        else
        {
            VelocidadMovimiento = velocidadInicial;
           player.SetBool("PuedoCorrer", false);
        }

       
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion,0);
        transform.Translate(0, 0, y * Time.deltaTime * VelocidadMovimiento);

        player.SetFloat("VelX", x);
        player.SetFloat("VelY", y);

        //CORRER 
        if (Input.GetKey(KeyCode.LeftShift)){
            VelocidadMovimiento = 10.0f;
            if(y>0)
            {
                player.SetBool("PuedoCorrer", true);
            }
            else
            {
                player.SetBool("PuedoCorrer", false);
            }

        }
        else
        {
            VelocidadMovimiento = velocidadInicial;
           player.SetBool("PuedoCorrer", false);
        }
    }
}