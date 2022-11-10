using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarColliders : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider golpeBoxCol;
    public BoxCollider patadaBoxCol;
    public MovPersonaje Personaje;

    public bool patadas;
    void Start()
    {
        DesactivarColliders();
    }

    // Update is called once per frame
    void Update()
    {
        patadas = Personaje.patada;
    }

    public void ActivarCollider()
    {
        if (patadas)
        {
            Debug.Log("entro a patada");
            patadaBoxCol.enabled = true;
        }
        else 
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
}
