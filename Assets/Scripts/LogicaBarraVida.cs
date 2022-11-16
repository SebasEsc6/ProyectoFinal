using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaBarraVida : MonoBehaviour
{
    private int vidaMax = 100;
    private GameManager gameManager;
    public Image ImagenBarraVida;
    private float vida;

    // Start is called before the first frame update
    void Start()
    {

        vida = gameManager.vida;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("tengo "+ vida);
        //RevisarVida();
        //if (gameManager.vida <= 0)
        //{
        //    gameObject.SetActive(false);
        //}

    }

    public void RevisarVida() 
    {
        //ImagenBarraVida.fillAmount = gameManager.vida / vidaMax;
    }

}
