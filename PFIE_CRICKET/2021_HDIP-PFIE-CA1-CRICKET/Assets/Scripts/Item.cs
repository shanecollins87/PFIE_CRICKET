using UnityEngine;

//// Taken from https://youtu.be/HQNl3Ff2Lpo (Interaction - Making an RPg in Unity(E04)) @4:50 onwards

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item" )]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;



    
  
}
