using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysLookAtTarget : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f; // this is to help aid smooth out the movement

    private Coroutine LookCoroutine; // tells it to start the coroutine

    public void StartRotating()
    {
        if (LookCoroutine != null)
        {

        StopCoroutine(LookCoroutine);
        }
        LookCoroutine = StartCoroutine(LookAt());


    }
    void Update()
    {
        transform.LookAt(Target); //, Vector3.up);
                                  // transform.position = Vector3.Lerp(transform.position,Target.position,0.0f);
    }
    private IEnumerator LookAt()
    {
        Quaternion lookRotation = Quaternion.LookRotation(Target.position); // basically grad our local position and the target position and get the direction vector

        float time = 0;

        while (time < 1) // while time is less than one
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time); // deals with time between 0 and 1

            time += Time.deltaTime * Speed; // this alters time in relation to speed 

            yield return null; // waits for the next frame 

        }
    }

}

