using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarColliders : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider golpeBoxCol;

    public bool puno;
    void Start()
    {
        DesactivarColliders();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ActivarCollider()
    {
            golpeBoxCol.enabled = true;
    }
    public void DesactivarColliders() 
    {
        golpeBoxCol.enabled = false;
    }

}
