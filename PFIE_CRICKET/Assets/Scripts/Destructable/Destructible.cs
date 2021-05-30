using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://youtu.be/EgNV0PWVaS8 I watched and followed this tutorial by Brakeys

public class Destructible : MonoBehaviour
{
    public GameObject destroyCrate;

    void OnMouseDown() // when the crate is clicked on mouse down is called 
    {
        Instantiate(destroyCrate, transform.position, transform.rotation); // Instantiate spawns at our current position and rotaion 
        Destroy(gameObject); // this will delete the old version
    }
}
