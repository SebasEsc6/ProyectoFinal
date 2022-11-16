using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumibleCorazon : MonoBehaviour
{
    private GameManager gameManager;
    public LogicaBarraVida barra;
    public bool entro;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        entro = true;
        gameManager.vida -= 10;
        Destroy(this.gameObject);
    }
}
