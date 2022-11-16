using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaBarraVida : MonoBehaviour
{
    public int vidaMax;
    public Image ImagenBarraVida;
    public float vida;
    private int health;
    private int dañoEnemy;


    // Start is called before the first frame update
    void Start()
    {
        dañoEnemy = 10;
        health = 10;
        vida = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();      
    }

    public void RevisarVida() 
    {
        ImagenBarraVida.fillAmount = vida / vidaMax;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Corazon")
        {
            vida += health;
            Destroy(other.gameObject);
        }
    }
}
