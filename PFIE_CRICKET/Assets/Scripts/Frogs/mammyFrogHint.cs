using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mammyFrogHint : MonoBehaviour
{
    public GameObject textMHint;
    public GameObject textClue5;
    public GameObject bgImage5;
    public GameObject bgborder5;

    // Start is called before the first frame update
    void Start()
    {
        textMHint.SetActive(false);  // begins with this Asset turned off
        textClue5.SetActive(false);  // begins with this Asset turned off
        bgImage5.SetActive(false);  // begins with this Asset turned off
        bgborder5.SetActive(false);  // begins with this Asset turned off

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            textMHint.SetActive(true);     // gets turned on
            textClue5.SetActive(true);     // gets turned on
            bgImage5.SetActive(true);     // gets turned on
            bgborder5.SetActive(true);     // gets turned on

            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(10);    // Leaves it on screen for the duration given
        textMHint.SetActive(false);  // begins with this Asset turned off
        textClue5.SetActive(false);  // begins with this Asset turned off
        bgImage5.SetActive(false);  // begins with this Asset turned off
        bgborder5.SetActive(false);  // begins with this Asset turned off



        //Destroy(textRiddle);                    //Removes Text Prompt
        //Destroy(textClue);                      //Removes clue Prompt
        //Destroy(bgImage);                       //Removes the background Image
        //Destroy(bgborder);                      //Removes the border/ overlay Image


    }

}