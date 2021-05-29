
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemParent;
    public GameObject inventoryUI;

    Inventory inventory; // cached for optimal speed
    InventorySlot [] slots;
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemParent.GetComponentsInChildren<InventorySlot>(); // make sure Components is pural as we want to get all the components
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf); // this checks if the Inventory UI is active if not it will set it as active
        
        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);

            }

            else 
            {

                slots[i].ClearSlot();
            }

        }
       
    }

}
