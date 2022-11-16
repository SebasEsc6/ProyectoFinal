using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int enemigosDerrotados;
    public float vida;
    // Start is called before the first frame update
    void Start()
    {
        enemigosDerrotados = 0;
        vida = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida < 1)
        {
            GameOver();
        }
    }

    void GameOver()
    {

    }
}
