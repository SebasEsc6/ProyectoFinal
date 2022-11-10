using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int vidaEnemigo;
    private Rigidbody enemyRb;
    private GameObject player;
    private GameObject efectoGolpe;
    private GameManager gameManager;
    public GameObject[] consumible;
    public Vector3 direction;
    private Animator animator;
    private bool attack;
    public float speed;
    public Transform attackPoint;
    public float attackRange = 0.7f;
    public LayerMask playerLayer;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = this.GetComponent<Rigidbody>();
        player = GameObject.Find("Miles");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animator = GetComponentInChildren<Animator>();
        vidaEnemigo = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (attack == false)
        {
            StartCoroutine(Attack());
        }
        if (vidaEnemigo < 1)
        {
            EliminarEnemigo();
        }
    }
    private void FixedUpdate()
    {
        if (player != null)
        {
            transform.LookAt(player.transform);
            SeguirJugador();
        }
    }

    private void SeguirJugador()
    {
        direction = (player.transform.position-transform.position);
        direction.Normalize();
        enemyRb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
    private void EliminarEnemigo()
    {
        Destroy(Instantiate(efectoGolpe, transform.position, transform.rotation), 2);
        gameManager.enemigosDerrotados += 1;

        int dejaConsumible = Random.Range(0, 2);
        if (dejaConsumible == 1)
        {
            int tipoConsum = Random.Range(0, 4);
            Destroy(Instantiate(consumible[tipoConsum], new Vector3(transform.position.x, 0.59f, 
                transform.position.z), transform.rotation), 5);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerPunch"))
        {
            vidaEnemigo -= 10;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player") && attack == true)
        {
            gameManager.vida -= 10;
        }
    }

    IEnumerator Attack()
    {

        Collider[] hitColliders = Physics.OverlapSphere(attackPoint.position, attackRange, playerLayer);

        foreach (var hitCollider in hitColliders)
        {
            attack = true;
            animator.SetTrigger("Attack");
            yield return new WaitForSeconds(1);
            attack = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
