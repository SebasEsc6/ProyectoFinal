using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform pos;
    public GameObject[] Enemigos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InstanciarEnemy();
    }

    private void InstanciarEnemy()
    {
        int n = Random.Range(0, Enemigos.Length);

        GameObject g = Instantiate(Enemigos[n], pos.position, 
            Enemigos[n].transform.rotation);
    }
}
