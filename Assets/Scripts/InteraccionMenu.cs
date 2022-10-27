using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionMenu : MonoBehaviour
{
    public GameObject PanelBotones;
    public GameObject PanelConfiguraciones;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarPanelBotones() 
    {
        PanelBotones.SetActive(true);
        PanelConfiguraciones.SetActive(false);
    }
    public void MostrarPanelConfiguraciones()
    {
        PanelBotones.SetActive(false);
        PanelConfiguraciones.SetActive(true);
    }

}
