using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{


    public GameObject teleportLocation;
    public float teleportCooldown = 3f;
    public bool teleportReady = true;

    private AudioSource myAudioSource;


    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

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
            myAudioSource.Play();
            other.gameObject.transform.position = teleportLocation.transform.position;
            teleportLocation.GetComponent<Teleport>().teleportCooldown = 3f;
            teleportLocation.GetComponent<Teleport>().teleportReady = false;
        }
    }
}

