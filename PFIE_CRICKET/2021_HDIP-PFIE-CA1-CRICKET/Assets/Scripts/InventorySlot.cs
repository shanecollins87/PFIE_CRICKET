using UnityEngine;
using UnityEngine.UI; // allows access and connection to Images in this case my eggIcon


// I followed Brackeys tutorial
public class InventorySlot : MonoBehaviour
{

    public Image icon;
    Item item;

    public void AddItem(Item newItem)
    {

        item = newItem;

        icon.sprite = item.icon; // the sprite Image is the Icon Image 
        icon.enabled = true; // currently in scene its turned off

    }

    public void ClearSlot() // to empty the spot
    {

        item = null;

        icon.sprite = null; // sets the sprite Image to null
        icon.enabled = false; // turn off in the scene

    }
}

