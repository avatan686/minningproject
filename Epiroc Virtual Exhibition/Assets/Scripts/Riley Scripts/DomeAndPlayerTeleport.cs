using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomeAndPlayerTeleport: MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public GameObject theDome;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = new Vector3 (200f,28f,-270f);
        theDome.transform.position = teleportTarget.transform.position;
    }
}