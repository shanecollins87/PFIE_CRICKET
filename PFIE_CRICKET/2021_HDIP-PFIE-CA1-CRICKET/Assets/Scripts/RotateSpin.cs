
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpin : MonoBehaviour
{

    public float RotateSpeed;
    public float speed = 0.1f;
    public float miny = 0;
    public float maxy = 0;


    //Public Vector3
    Vector3 vector;


    // Start is called before the first frame update
    void Start()
    {
        RotateSpeed = .1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.Rotate(0, 1, 0 * Time.deltaTime);
        }

        transform.Rotate(0, RotateSpeed, 1);
        // we want the cube to move up and down between x = -5 and x = 5
        transform.position += speed * vector;

        //if we reach x = 5 and were moving up, then we now need to reverse dirction
        if (transform.position.y >= maxy && speed > 0)
        {
            speed *= -1;
        }



        //if we reach x = 5 and were moving up, then we now need to reverse dirction
        if (transform.position.y <= miny && speed < 0)
        {
            speed *= -1;
        }



    }
}



