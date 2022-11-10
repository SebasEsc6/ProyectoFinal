using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    public int dañoPuño;
    public int dañoPatada;
    public Animator anim;

    void Start()
    {
        dañoPatada = 5;
        dañoPuño = 4;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "puñoImpacto")
        {
            if (anim != null)
            {
                anim.Play("AnimacionHitEnemigo");
            }
            hp -= dañoPuño;
        }
        if (other.gameObject.tag == "patadaImpacto")
        {
            if (anim != null)
            {
                anim.Play("AnimacionHitEnemigo");
            }
            hp -= dañoPatada;
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
