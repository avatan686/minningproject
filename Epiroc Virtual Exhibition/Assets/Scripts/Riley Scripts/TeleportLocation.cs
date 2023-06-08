using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLocation : MonoBehaviour
{
   public Transform teleportTarget; 
  
  

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="teleport")

        {
            gameObject.transform.position = teleportTarget.transform.position; 
        }
    }

  

}
