using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Teleport : MonoBehaviour
{
   //Create a target to teleport to.

    public Transform teleportTarget;

    // transport a game object from one point to another.
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {

        // Create a means of getting the player to the teleport target.

        Player.transform.position = teleportTarget.transform.position;
    }
}


