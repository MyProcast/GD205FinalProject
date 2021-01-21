using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazardScripts : MonoBehaviour
{
    public GameObject player;
    public Transform spawn;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hazard")
        {
            //player.transform.position = spawn.transform.position;
        }
    }
}

