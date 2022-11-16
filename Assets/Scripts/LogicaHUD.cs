using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaHUD : MonoBehaviour
{
    public GameObject CanvaVivo;
    public GameObject CanvaLoose;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MostrarLoose()
    {
        CanvaLoose.SetActive(true);
        CanvaLoose.SetActive(false);
    }
}
