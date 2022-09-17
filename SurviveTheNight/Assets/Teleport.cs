using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{


    public GameObject teleportLocation;
    public float teleportCooldown = 3f;
    public bool teleportReady = true;


    private void Update()
    {
        if (teleportCooldown > 0 && teleportReady == false) 
        {
            teleportCooldown -= Time.deltaTime;
        }

        if (teleportCooldown < 0)
        {
            teleportReady = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && teleportReady)
        {
            other.gameObject.transform.position = teleportLocation.transform.position;
            teleportLocation.GetComponent<Teleport>().teleportCooldown = 3f;
            teleportLocation.GetComponent<Teleport>().teleportReady = false;
        }
    }
}

