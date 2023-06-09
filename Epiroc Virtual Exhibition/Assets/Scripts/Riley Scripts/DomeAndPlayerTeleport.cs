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
        thePlayer.transform.position = new Vector3 (210f,32.5f,-278f);
        theDome.transform.position = teleportTarget.transform.position;
    }
}