using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    public int da�oPu�o;
    public int da�oPatada;
    public Animator anim;

    void Start()
    {
        da�oPatada = 5;
        da�oPu�o = 4;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pu�oImpacto")
        {
            if (anim != null)
            {
                anim.Play("AnimacionHitEnemigo");
            }
            hp -= da�oPu�o;
        }
        if (other.gameObject.tag == "patadaImpacto")
        {
            if (anim != null)
            {
                anim.Play("AnimacionHitEnemigo");
            }
            hp -= da�oPatada;
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
