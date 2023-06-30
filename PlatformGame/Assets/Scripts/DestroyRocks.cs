using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRocks : MonoBehaviour
{
    GameObject DestroyRock;

    private void Start()
    {
        DestroyRock = GameObject.FindGameObjectWithTag("DestroyRock");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == DestroyRock)
        {
            Destroy(gameObject);
        }
    }
}
