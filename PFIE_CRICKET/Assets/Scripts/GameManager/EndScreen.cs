using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{ 
      public GameObject endScreen; // On successful completion of the game this screen will pop up
        // Start is called before the first frame update
        void Start()
        {
        endScreen.SetActive(false);  // begins with it turned turned off
        }

        // Update is called once per frame
        void OnTriggerEnter(Collider player)  // when the player collides with the sixth egg, the play will have the player tag
        {
            if (player.gameObject.tag == "Player")
            {
                endScreen.SetActive(true);     // gets turned on
                StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
            }
        }
        IEnumerator WaitForSec()  // allows us to use real time seconds to wait
        {
            yield return new WaitForSeconds(10);    // Leaves it on screen for the duration given
            
                                                   

        }

    }