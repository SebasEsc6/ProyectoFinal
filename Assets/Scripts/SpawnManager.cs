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

        yield return new WaitForSeconds(4);

        for (int i= 0; i < waveC; i++)
        {
            SpawnEnemigos(onda);
            yield return new WaitForSeconds(2);
        }
        onda += 1;
        contadorOnda += 2;
        spawning = false;

        yield break;
    }
    
    void SpawnEnemigos(int onda)
    {
        int spawnPos = Random.Range(0, 4);
        if (onda == 1)
        {
            tipoEnemigo = 1;
        }
        else if (onda < 4)
        {
            tipoEnemigo = Random.Range(0, 2);
        }
        else
        {
            tipoEnemigo = Random.Range(0, 3);
        }

        Instantiate(enemigos[tipoEnemigo], spawnPoints[spawnPos].transform.position,spawnPoints[spawnPos].transform.rotation);
        enemigosSpawneados += 1;
    }
}
