using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Ive set yup 3 pressure plates in my scene to move the door -5 each time allowing access to the teleporter into the internal room

//https://youtu.be/6vj_Ie9i-Ak I watched this video for my door


public class BabyDoorTrigger : MonoBehaviour
{
    [SerializeField] // Visible in the Inspector
    GameObject door1;

    bool isOpened = false;

    void OnTriggerEnter(Collider col) // when the player collider collides with the plate the action is triggered
    {
        if (!isOpened) //! = false
        {
            isOpened = true; // this prevents the door going up and up basically it asks has the action been done if so you dont need to repeat
            door1.transform.position += new Vector3(0, -1, 0); // the door moves up 8 in the yaxis (verticle only as this is all tahts required)


        }
    }
}


