using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add thsi script to your pressure plate
// Then assign the door variable - seen because of Serializefield

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    bool isOpened = false;

    void OnTriggerEnter(Collider col)
    {
        if (!Opened)
        {
            isOpened = true;
        door.transform.position += new Vector3(0, 4, 0);
        }

    }
}