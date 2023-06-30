using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGroundForJump : MonoBehaviour
{
    //This is for whether character is in ground or not.

    public bool isGround;

    private void OnTriggerEnter(Collider other)
    {
        isGround = true;
    }

    private void OnTriggerStay(Collider other)
    {
        isGround = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isGround = false;
    }
}
