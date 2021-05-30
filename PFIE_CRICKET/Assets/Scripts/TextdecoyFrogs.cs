using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextdecoyFrogs : MonoBehaviour
{
    public GameObject textDecoy;
    public GameObject textNonClue;
    public GameObject bgImage2;
    public GameObject bgborder2;

    // Start is called before the first frame update
    void Start()
    {
        textDecoy.SetActive(false);  // begins with this Asset turned off
        textNonClue.SetActive(false);  // begins with this Asset turned off
        bgImage2.SetActive(false);  // begins with this Asset turned off
        bgborder2.SetActive(false);  // begins with this Asset turned off

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            textDecoy.SetActive(true);     // gets turned on
            textNonClue.SetActive(true);     // gets turned on
            bgImage2.SetActive(true);     // gets turned on
            bgborder2.SetActive(true);     // gets turned on

            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(2);    // Leaves it on screen for the duration given
        textDecoy.SetActive(false);  // begins with this Asset turned off
        textNonClue.SetActive(false);  // begins with this Asset turned off
        bgImage2.SetActive(false);  // begins with this Asset turned off
        bgborder2.SetActive(false);  // begins with this Asset turned off



        //Destroy(textRiddle);                    //Removes Text Prompt
        //Destroy(textClue);                      //Removes clue Prompt
        //Destroy(bgImage);                       //Removes the background Image
        //Destroy(bgborder);                      //Removes the border/ overlay Image


    }

}