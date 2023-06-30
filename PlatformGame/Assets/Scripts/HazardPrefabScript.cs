using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardPrefabScript : MonoBehaviour
{
    //For the rocks to be regenerated for a certain period of time

    public GameObject rock;
    public Transform spawnPosition;

    void Start()
    {
        StartCoroutine(Waiter());
        
    }

    void InstantiateFunction()
    {
        Instantiate(rock, spawnPosition.position, Quaternion.identity);
        rock.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 5);
    }

    IEnumerator Waiter()
    {
        
        yield return new WaitForSeconds(5f);
        InstantiateFunction();
        StartCoroutine(Waiter2());
    }

    IEnumerator Waiter2()
    {
        
        yield return new WaitForSeconds(5f);
        StartCoroutine(Waiter());
    }
}
