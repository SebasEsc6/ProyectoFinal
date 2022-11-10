using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarColliders : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider pu�oBoxCol;
    public BoxCollider patadaBoxCol;
    public MovPersonaje Personaje;
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
        if (Personaje.patada == true)
        {
            patadaBoxCol.enabled = true;
        }
        else 
        {
            pu�oBoxCol.enabled = true;
        }
    }
    public void DesactivarColliders() 
    {
        patadaBoxCol.enabled = false;
        pu�oBoxCol.enabled = false;
    }
}
