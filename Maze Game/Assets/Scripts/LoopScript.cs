using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ball)
        {
            ball.transform.position = new Vector3(0, 5, 0);
        }
    }
}
