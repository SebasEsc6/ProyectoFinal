using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    public Transform player;
    public Vector3 camOffset;


    [Range(0.1f, 1.0f)]
    public float SmoothFactor = 0.1f;

    private void Start()
    {
        camOffset = transform.position - player.position;
    }

    private void Update()
    {
        Vector3 newPos = player.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

    }

}