using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarHUD : MonoBehaviour
{
    //Variable para asociar el objeto Texto Tiempo
    public Text textoTiempo;
    public float tiempo;

    //Script GameManager
    private GameManager gameManager;

    void Start()
    {

        //Inicializo el texto del contador de tiempo
        textoTiempo.text = "Tiempo: 00:00";

        //Capturo el script de GameManager
        gameManager = FindObjectOfType<GameManager>();

    }

    void Update()
    {

        //Escribo tiempo transcurrido (si no se ha acabado el juego)

        textoTiempo.text = "Tiempo: " + formatearTiempo();
        

    }

    //Formatear tiempo (público porque la necesitaremos más adelante)
    public string formatearTiempo()
    {
        tiempo += Time.deltaTime;

        //Formateo minutos y segundos a dos dígitos
        string minutos = Mathf.Floor(tiempo / 60).ToString("00");
        string segundos = Mathf.Floor(tiempo % 60).ToString("00");

        //Devuelvo el string formateado con : como separador
        return minutos + ":" + segundos;

    }
}
