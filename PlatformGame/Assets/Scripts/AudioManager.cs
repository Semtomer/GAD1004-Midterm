using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource _mabms;

    // Start is called before the first frame update
    void Start()
    {
        _mabms = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameSound").GetComponent<AudioSource>().Stop();
            _mabms.Play();
        }
    }
}
