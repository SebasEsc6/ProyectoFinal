using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaBarraVida : MonoBehaviour
{
    public int vidaMax;
    public Image ImagenBarraVida;
    public float vida;
    private int health;
    private int da�oEnemy;
    public GameObject CanvaVivo;
    public GameObject CanvaLoose;
    public string EscenaPrincipio;

    // Start is called before the first frame update
    void Start()
    {
        da�oEnemy = 10;
        health = 10;
        vida = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();
        if (vida <= 0) 
        {
            MostrarLoose();
        }
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






    //MANEJAR HUD Y ESCENAS
    public void MostrarLoose()
    {
        CanvaLoose.SetActive(true);
        CanvaVivo.SetActive(false);
    }
    public void VolverEmpezar()
    {
        SceneManager.LoadScene(EscenaPrincipio);
    }

}
