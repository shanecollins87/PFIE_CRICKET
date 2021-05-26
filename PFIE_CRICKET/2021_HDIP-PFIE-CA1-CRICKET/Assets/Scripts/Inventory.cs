using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance; // Singleton 

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Dupliacate instance of inventory found");
            return;
        
        }
        instance = this;
    
    }

    #endregion

    public delegate void OnItemChanged();      //A delegate allows for differnt methods subscribed to teh same event 
    public OnItemChanged onItemChangedCallback;

    public int space = 10; // limited space

    public List<Item> items = new List<Item>();

    public bool Add (Item item) // In the case were we pick item up but have no space intead of deleting it, it will remain in the scene
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space) // checks to see if the item count is 10 (our alloted spaces) or greater than and will write the next message
            {

                Debug.Log("Not enough room");
            return false;
            }

            items.Add(item);

            if (onItemChangedCallback != null) // will check, something is needed otherwise it will produce an error
            onItemChangedCallback.Invoke();


        }
        return true; // if item is picked up
    }

    public void Remove (Item item)
    {
        items.Remove (item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
