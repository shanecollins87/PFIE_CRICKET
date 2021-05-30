using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggCollectionUI : MonoBehaviour
{
    public GameObject eggAmount;
    public GameObject uiScreen;
    public GameObject uiImage;
   

    // Start is called before the first frame update
    void Start()
    {
        eggAmount.SetActive(false);  // begins with this Asset turned off
        uiScreen.SetActive(false);  // begins with this Asset turned off
        uiImage.SetActive(false);  // begins with this Asset turned off
       
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)  // when the player collides with player tag
    {
        if (player.gameObject.tag == "Player")
        {
            eggAmount.SetActive(true);     // gets turned on
            uiScreen.SetActive(true);  //  gets turned on
            uiImage.SetActive(true);     // gets turned on
            

            StartCoroutine("WaitForSec");   // Coroutine allows IEnumerator to be called
        }
    }
    IEnumerator WaitForSec()  // allows us to use real time seconds to wait
    {
        yield return new WaitForSeconds(10);    // Leaves it on screen for the duration given
        //eggAmount.SetActive(false);  // begins with this Asset turned off
        //uiScreen.SetActive(false);  // begins with this Asset turned off
        //uiImage.SetActive(false);  // begins with this Asset turned off
        



        //Destroy(textRiddle);                    //Removes Text Prompt
        //Destroy(textClue);                      //Removes clue Prompt
        //Destroy(bgImage);                       //Removes the background Image
        //Destroy(bgborder);                      //Removes the border/ overlay Image


    }


}
