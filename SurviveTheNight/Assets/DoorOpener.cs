using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{




    public Animator MyDoorAnimator;
    public bool opened = false;
    public bool closed = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (opened)
            {
                MyDoorAnimator.Play("DoorOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closed)
            {
                MyDoorAnimator.Play("DoorClose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
