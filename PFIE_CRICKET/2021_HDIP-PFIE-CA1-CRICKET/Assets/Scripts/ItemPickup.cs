
using UnityEngine;

public class ItemPickup : Interactable

{
    public Item item;
    public override void Interact()
    {
        base.Interact();


        PickUp();

    }

    void PickUp()
    {

        Debug.Log("Picking up" + item.name);
        bool wasPickedUp = Inventory.instance.Add(item); // Checks if item was picked up and if so Adds to inventory
        if (wasPickedUp) // this checks to see if the item was picked up and if so it will destroy it
            Destroy(gameObject);

    }


}
