using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public MovPersonaje movperso;

    private void OnTriggerStay(Collider other)
    {
        movperso.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        movperso.puedoSaltar = false;
    }
}
