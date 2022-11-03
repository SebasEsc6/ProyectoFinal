using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPuerta : MonoBehaviour
{
    public string Segunda;
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

            SceneManager.LoadScene(Segunda);


            
        }
    }


}


