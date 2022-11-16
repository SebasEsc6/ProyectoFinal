using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    public int danoPuno;
    public int danoPatada;
    public int dano;
    public Animator anim;
    private GameManager gameManager;
    public float rangoAlerta;
    public LayerMask capaDelJugador;
    public bool estarAlerta;
    public Transform jugador;
    public float velocidad;
    public float rangoGolpe;
    public bool golpearJugador;
   
    
    

    void Start()
    {
        hp = 100;
        danoPatada = 5;
        danoPuno = 15;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoAlerta, capaDelJugador);

        if (estarAlerta == true)
        {
            Vector3 posJugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            Vector3 posEnemy = new Vector3(transform.position.x, jugador.position.y, transform.position.z);
            transform.LookAt(posJugador);
            transform.position = Vector3.MoveTowards(transform.position, posJugador, velocidad*Time.deltaTime);

            anim.SetFloat("VelX", posEnemy.x);
            anim.SetFloat("VelY", posEnemy.y);

            anim.SetBool("Traque", false);
            anim.SetBool("MePegaron", false);
        }

        golpearJugador = Physics.CheckSphere(transform.position, rangoGolpe, capaDelJugador);

        if(golpearJugador == true)
        {
            anim.SetBool("Traque", true);
            
        }
    }

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "golpeImpacto")
        {
            dano = danoPuno;
            if (anim != null)
            {
                Debug.Log("Quite" + dano);
                anim.SetBool("MePegaron", true);
                
            }
            hp -= dano;
        }
        else
        {
            anim.SetBool("MePegaron", false);
        }
     
        if (hp <= 0)
        {
            anim.SetBool("Mori", true);
            Destroy(gameObject);
        }
    }
}
