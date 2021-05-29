using UnityEngine;

//// Taken from https://youtu.be/HQNl3Ff2Lpo (Interaction - Making an RPg in Unity(E04)) @4:50 onwards

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item" )]

//public class Item : MonoBehaviour
public class Item : ScriptableObject

{ 

    new public string name = "New Item";       //name of the item
    public Sprite icon = null;                 // Item Icon
    public bool isDefaultItem = false;         //Is the item default wear?

    public virtual void Use()
    {

        //Use the item, Something may happen

        Debug.Log("Using" + name);

    }

}
