using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldenEggWin : MonoBehaviour
{
    public GameObject goldenEggPrompt;
    public GameObject textClue1;
    public GameObject bgImage1;
    public GameObject bgborder1;

    // Start is called before the first frame update
    void Start()
    {
        goldenEggPrompt.SetActive(false);  // begins with this Asset turned off
        textClue1.SetActive(false);  // begins with this Asset turned off
        bgImage1.SetActive(false);  // begins with this Asset turned off
        bgborder1.SetActive(false);  // begins with this Asset turned off

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            goldenEggPrompt.SetActive(true);     // gets turned on
            textClue1.SetActive(true);     // gets turned on
            bgImage1.SetActive(true);     // gets turned on
            bgborder1.SetActive(true);     // gets turned on

            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(10);    // Leaves it on screen for the duration given
        goldenEggPrompt.SetActive(false);  // begins with this Asset turned off
        textClue1.SetActive(false);  // begins with this Asset turned off
        bgImage1.SetActive(false);  // begins with this Asset turned off
        bgborder1.SetActive(false);  // begins with this Asset turned off



        //Destroy(goldenEggPrompt);                    //Removes Text Prompt
        //Destroy(textClue1);                      //Removes clue Prompt
        //Destroy(bgImage1);                       //Removes the background Image
        //Destroy(bgborder1);                      //Removes the border/ overlay Image


    }

}