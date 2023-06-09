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
        thePlayer.transform.position = new Vector3 (220f,33f,-278f);
        theDome.transform.position = teleportTarget.transform.position;
    }
}