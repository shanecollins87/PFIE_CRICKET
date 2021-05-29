using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPrompts : MonoBehaviour
{
    public GameObject doorRiddle;
    // Start is called before the first frame update
    void Start()
    {
        doorRiddle.SetActive(false);  // begins turned off
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            doorRiddle.SetActive(true);     // gets turned on
            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(40);    // Leaves it on screen for the duration given
        Destroy(doorRiddle);                    //Removes doorRiddle Prompt
        //Destroy(gameObject);

    }

}