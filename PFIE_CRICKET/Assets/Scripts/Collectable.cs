using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*





    // uses previous video on PlayerMovemnt
    // Create a second cube call it Power up add new material, Physics needs to be enabled by adding Rigidbody and turn off Use Gravity
    // then select is Trigger and turn on to make object turn ghost
    // Create a new c# script called Collectable and attached to desired items
    // PLayer needs to be tagged player
*/

public class Collectable : MonoBehaviour
{

    [SerializeField]

    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public float attackStrenght;
    public string itemType;
    public AudioSource coinSound; //playsound



    private void OnTriggerEnter(Collider collider)
        
    {
        if (collider.tag == "Player")
        {
            // have it also add points
            // add power up etc. before being destroyed
            string itemType = GetComponent<Collider>().gameObject.GetComponent<Collectable>().itemType;
            
            print ("You have eaten a:" + itemType);


            // Play sound
            //coinSound.Play();
            // itemType.Add(itemType);
            Destroy(this.gameObject);

        }

    }



}









   