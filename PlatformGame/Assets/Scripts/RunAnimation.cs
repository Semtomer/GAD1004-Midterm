using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnimation : MonoBehaviour
{
    //For animations to work when it enters the collision area.

    public GameObject Player;
    Animator _parentAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            _parentAnimator = GetComponentInParent<Animator>();
            _parentAnimator.SetTrigger("TriggerHazard");
        }
    }
}
