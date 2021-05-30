using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daddyFrogHint : MonoBehaviour
{
    public GameObject textDHint;
    public GameObject textClue4;
    public GameObject bgImage4;
    public GameObject bgborder4;

    // Start is called before the first frame update
    void Start()
    {
        textDHint.SetActive(false);  // begins with this Asset turned off
        textClue4.SetActive(false);  // begins with this Asset turned off
        bgImage4.SetActive(false);  // begins with this Asset turned off
        bgborder4.SetActive(false);  // begins with this Asset turned off

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            textDHint.SetActive(true);     // gets turned on
            textClue4.SetActive(true);     // gets turned on
            bgImage4.SetActive(true);     // gets turned on
            bgborder4.SetActive(true);     // gets turned on

            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(10);    // Leaves it on screen for the duration given
        textDHint.SetActive(false);  // begins with this Asset turned off
        textClue4.SetActive(false);  // begins with this Asset turned off
        bgImage4.SetActive(false);  // begins with this Asset turned off
        bgborder4.SetActive(false);  // begins with this Asset turned off



        //Destroy(textRiddle);                    //Removes Text Prompt
        //Destroy(textClue);                      //Removes clue Prompt
        //Destroy(bgImage);                       //Removes the background Image
        //Destroy(bgborder);                      //Removes the border/ overlay Image


    }

}