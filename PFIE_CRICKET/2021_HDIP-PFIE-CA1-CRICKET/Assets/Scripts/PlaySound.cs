using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Trigger an audio event then collision happens.

    public AudioSource soundClip;


     // on trigger function
    void OnTriggerEnter(Collider other)
    {

        //plays a sound.

        soundClip.Play();

    }
}

