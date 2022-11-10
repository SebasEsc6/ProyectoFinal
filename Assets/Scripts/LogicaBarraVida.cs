using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaBarraVida : MonoBehaviour
{
    public int vidaMax;
    public float vidaActual;
    public Image ImagenBarraVida; 

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;   
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();
        if (vidaActual <= 0) 
        {
            gameObject.SetActive(false);
        }

    }

    public void RevisarVida() 
    {
        ImagenBarraVida.fillAmount = vidaActual / vidaMax;
    }

}
