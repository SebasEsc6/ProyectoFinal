using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger2 : MonoBehaviour
{
    public string Tercera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter(Collider C)
    {


        
        if(C.tag == "Player"){

            Debug.Log(C.name);


            SceneManager.LoadScene(Tercera);



            
        }
    }


}


