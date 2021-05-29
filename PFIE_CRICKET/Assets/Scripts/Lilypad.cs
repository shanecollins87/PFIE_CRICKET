using System.Collections;
using System.Collections.Generic;
using UnityEngine;


////https://youtu.be/6vj_Ie9i-Ak After watching this 
public class Lilypad : MonoBehaviour

  

{
    [SerializeField] // Visible in the Inspector
    GameObject lilypad;

    bool isOpened = false;

    void OnTriggerEnter(Collider col) // when the player collider collides with the lilypad the action is triggered
    {
        //if (!isOpened) //! = false
        {
           // isOpened = true; // this prevents the door going up and up basically it asks has the action been done if so you dont need to repeat
            lilypad.transform.position += new Vector3(8, 0, 0); // the lillypad moves up 0 in the  y axis only (horizontal only as this is all thats required)


        }
    }
}


