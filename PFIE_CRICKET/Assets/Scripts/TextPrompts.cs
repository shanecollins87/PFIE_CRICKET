using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPrompts : MonoBehaviour
{
    public GameObject textRiddle;
    public GameObject textClue;
    public GameObject bgImage;
    public GameObject bgborder;

    // Start is called before the first frame update
    void Start()
    {
        textRiddle.SetActive(false);  // begins with this Asset turned off
        textClue.SetActive(false);  // begins with this Asset turned off
        bgImage.SetActive(false);  // begins with this Asset turned off
        bgborder.SetActive(false);  // begins with this Asset turned off

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            textRiddle.SetActive(true);     // gets turned on
            textClue.SetActive(true);     // gets turned on
            bgImage.SetActive(true);     // gets turned on
            bgborder.SetActive(true);     // gets turned on

            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(10);    // Leaves it on screen for the duration given
        Destroy(textRiddle);                    //Removes Text Prompt
        Destroy(textClue);                      //Removes clue Prompt
        Destroy(bgImage);                       //Removes the background Image
        Destroy(bgborder);                      //Removes the border/ overlay Image


    }

}