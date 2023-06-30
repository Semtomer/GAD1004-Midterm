using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardScript : MonoBehaviour
{
    // This script works when the player fails.
    // When he fall into the water or when you touch the thorns, when you say thorns.
    // I check all of them with colliders.

    GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Player)
        {
            Player.transform.position = Player.GetComponent<CheckpointScript>().currentCheckpoint;

            if (gameObject.tag == "TriggeringHazard")
            {
                Destroy(gameObject);
            }
        }
    }
}
