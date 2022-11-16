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

    void Start()
    {
        hp = 30;
        danoPatada = 5;
        danoPuno = 4;
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoAlerta, capaDelJugador);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoAlerta);
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
        if (other.gameObject.tag == "patadaImpacto")
        {
            dano = danoPatada;
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
