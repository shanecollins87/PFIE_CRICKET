using System.Collections;
using UnityEngine;


//https://youtu.be/2XEiHf1N_EY How to make an Object Smoothly Turn to Look At Another Object 
public class SimpleRotate : MonoBehaviour
{

    public float RotationAmount = 2f;
    public int TicksPerSecond = 60;
    public int rotationSpeed = 180;
    public bool Pause = false;


  

private void Start()
    {
        StartCoroutine(Rotate());

    }
    private IEnumerator Rotate()
    {

        WaitForSeconds Wait = new WaitForSeconds(1f / TicksPerSecond);

        while (true)
        {
            if (!Pause)
            {
                transform.Rotate(Vector3.up * RotationAmount);
            }
            yield return Wait;

    }
   } 
}

    

