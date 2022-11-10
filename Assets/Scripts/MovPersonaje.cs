using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float velocidadInicial = 15f;
    public float velocidadRotacion = 200.0f;
    public float fuerzaSalto = 8f;
    public float x, y, VelocidadMovimiento;
    public float impulsoDeGolpe = 10f;
    public Rigidbody rb;
    private Animator player;

    public bool patada;
    public bool estoyAtacando;
    public bool avanzoSolo;
    public bool puedoSaltar;


    void Start()
    {
        player = GetComponent<Animator>();
        puedoSaltar = false;
    }
    private void FixedUpdate()
    {
        if (avanzoSolo)
        {
            rb.velocity = transform.forward * impulsoDeGolpe;
        }
        if (patada)
        {
            rb.velocity = - transform.forward * impulsoDeGolpe;
        }
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Mouse0) && puedoSaltar && !estoyAtacando)
        {
            player.SetTrigger("Golpeo");          
            estoyAtacando = true;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && puedoSaltar && !estoyAtacando)
        {
            player.SetTrigger("Patee");
            estoyAtacando = true;
        }

        VelocidadMovimiento = velocidadInicial;
        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            VelocidadMovimiento = 20.0f;
            if (y > 0)
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

        if (!estoyAtacando) {
            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * VelocidadMovimiento);
        }

        player.SetFloat("VelX", x);
        player.SetFloat("VelY", y);

        //CORRER 
        if (Input.GetKey(KeyCode.LeftShift)) {
            VelocidadMovimiento = 20.0f;
            if (y > 0)
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
        //SALTAR
        if (puedoSaltar)
        {
            if (!estoyAtacando)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    player.SetBool("Salte", true);
                    rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);

                }
            }           
            player.SetBool("TocoSuelo", true);
        }
        else 
        {
            EstoyCayendo();
        }

        

    }
    public void EstoyCayendo() {
        player.SetBool("TocoSuelo", false);
        player.SetBool("Salte", false);

    }
    public void DejeDeGolpear() 
    {
        estoyAtacando = false;
    }
    public void AvanzoSolo() 
    {
        avanzoSolo = true;
    }
    public void DejoDeAvanzar() 
    {
        avanzoSolo = false;
    }
    public void Patee() 
    {
        patada = true;
    }
    public void DejePatiar()
    {
        estoyAtacando = false;
        patada = false;
    }

}