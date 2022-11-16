using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarColliders : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider golpeBoxCol;
    public BoxCollider patadaBoxCol;
    public MovPersonaje Personaje;

    public bool patada;
    public bool puno;
    void Start()
    {
        DesactivarColliders();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ActivarCollider()
    {
        if (patada)
        {
            Debug.Log("entro a patada");
            patadaBoxCol.enabled = true;
        }
        if(puno) 
        {
            Debug.Log("entro a GOLPE");
            golpeBoxCol.enabled = true;
        }
    }
    public void DesactivarColliders() 
    {
        patadaBoxCol.enabled = false;
        golpeBoxCol.enabled = false;
    }
    public void Patada() 
    {
        puno = false;
        patada = true;
    }
    public void golpe()
    {
        patada = false;
        puno = true;        
    }
}
