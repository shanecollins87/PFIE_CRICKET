using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//https://youtu.be/6vj_Ie9i-Ak I watched this video for my door


public class DoorTrigger : MonoBehaviour
{
    [SerializeField] // Visible in the Inspector
    GameObject door;

    bool isOpened = false;

    void OnTriggerEnter(Collider col) // when the player collider collides with the plate the action is triggered
    {
        if (!isOpened) //! = false
        {
            isOpened = true; // this prevents the door going up and up basically it asks has the action been done if so you dont need to repeat
            door.transform.position += new Vector3(0, -14, 0); // the door moves up 8 in the yaxis (verticle only as this is all tahts required)
         

        }
    }
}


