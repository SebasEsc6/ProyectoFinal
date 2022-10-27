using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator player;
    public float x, y;  

    void Start()
    {
        player = GetComponent<Animator>();   
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion,0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, -y * Time.deltaTime * 2f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, y * Time.deltaTime * 2f, 0);
        }


        player.SetFloat("VelX", x);
        player.SetFloat("VelY", y);
    }
}
