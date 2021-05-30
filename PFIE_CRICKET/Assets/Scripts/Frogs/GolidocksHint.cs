using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GolidocksHint : MonoBehaviour
{
    public GameObject textGHint;
    public GameObject textClue3;
    public GameObject bgImage3;
    public GameObject bgborder3;

    // Start is called before the first frame update
    void Start()
    {
        textGHint.SetActive(false);  // begins with this Asset turned off
        textClue3.SetActive(false);  // begins with this Asset turned off
        bgImage3.SetActive(false);  // begins with this Asset turned off
        bgborder3.SetActive(false);  // begins with this Asset turned off

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            textGHint.SetActive(true);     // gets turned on
            textClue3.SetActive(true);     // gets turned on
            bgImage3.SetActive(true);     // gets turned on
            bgborder3.SetActive(true);     // gets turned on

            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(10);    // Leaves it on screen for the duration given
        textGHint.SetActive(false);  // begins with this Asset turned off
        textClue3.SetActive(false);  // begins with this Asset turned off
        bgImage3.SetActive(false);  // begins with this Asset turned off
        bgborder3.SetActive(false);  // begins with this Asset turned off



        //Destroy(textRiddle);                    //Removes Text Prompt
        //Destroy(textClue);                      //Removes clue Prompt
        //Destroy(bgImage);                       //Removes the background Image
        //Destroy(bgborder);                      //Removes the border/ overlay Image


    }

}