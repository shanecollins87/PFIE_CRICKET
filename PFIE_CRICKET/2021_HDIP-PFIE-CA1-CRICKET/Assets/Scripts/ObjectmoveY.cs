using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectmoveY : MonoBehaviour
{

    public float speed = 0.1f;
    public float minX = -5;
    public float maxX = 5;


    //Public Vector3
    Vector3 vector;


    // Start is called before the first frame update
    void Start()
    {
        vector = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // we want the cube to move up and down between x = -5 and x = 5
        transform.position += speed * vector;

        //if we reach x = 5 and were moving up, then we now need to reverse dirction
        if (transform.position.x >= maxX && speed > 0)
        {
            speed *= -1;
        }



        //if we reach x = 5 and were moving up, then we now need to reverse dirction
        if (transform.position.x <= minX && speed < 0)
        {
            speed *= -1;
        }



    }
}