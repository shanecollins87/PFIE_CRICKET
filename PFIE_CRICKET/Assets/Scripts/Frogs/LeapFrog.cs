using System.Collections;
using System.Collections.Generic;
using UnityEngine;


////https://youtu.be/6vj_Ie9i-Ak After watching this 
public class LeapFrog : MonoBehaviour

  

{
    [SerializeField] // Visible in the Inspector
    GameObject leapfrog;

    bool hasJumped = false;

    void OnTriggerEnter(Collider col) // when the player collider collides with the lilypad the action is triggered
    {
        if (!hasJumped) //! = false
        {
           hasJumped = true; // this prevents the door going up and up basically it asks has the action been done if so you dont need to repeat
           leapfrog.transform.position += new Vector3(-2, 0, 0); // the lillypad moves up 0 in the  y axis only (horizontal only as this is all thats required)


        }
    }
}


