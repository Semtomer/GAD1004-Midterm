using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    //This is for checkpoint.

    Vector3 startingPosition = new Vector3(20f,6f,-4f);
    Vector3 Checkpoint = new Vector3(20f, 9f, -55f);
    public Vector3 currentCheckpoint;

    private void Start()
    {
        currentCheckpoint = startingPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            currentCheckpoint = Checkpoint;
            //When the player gets a checkpoint, the flag goes.
            Destroy(other.gameObject, 2);
        }
    }
}
