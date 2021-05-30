using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{

    //declare a ray and Ray Caster.

    Ray ray;
    RaycastHit hit;

    // declare a public game object.
   // public GameObject ObjectCreate;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //iniation distance of ray cast

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 20;

        Debug.DrawRay(transform.position, forward, Color.red);

        // Address camera for viewing during play
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.10f));

        // Create some interaction
        // Generated and pointing to an object

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            // address the mouse click

            //if (Input.GetMouseButtonDown(0))
            //{
            //    // Create or generate an object
            //    Instantiate(ObjectCreate, hit.point, Quaternion.identity);
            }
        }

    }
//}