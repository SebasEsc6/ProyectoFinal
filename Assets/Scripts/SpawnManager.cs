using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] enemigos;
    public int contadorOnda;
    public int onda;
    public int tipoEnemigo;
    public bool spawning;
    private int enemigosSpawneados;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        contadorOnda = 2;
        onda = 1;
        spawning = false;
        enemigosSpawneados = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawning == false && enemigosSpawneados == gameManager.enemigosDerrotados)
        {
            StartCoroutine(SpawnWave(contadorOnda));
        }
    }

    IEnumerator SpawnWave(int waveC)
    {
        spawning = true;
    }
}
