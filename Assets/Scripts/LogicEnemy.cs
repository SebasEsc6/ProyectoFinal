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

    void Start()
    {
        hp = 100;
        danoPatada = 5;
        danoPuno = 4;
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
                anim.Play("Zombie Reaction Hit");
                
            }
            hp -= dano;
        }
     
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
