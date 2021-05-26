using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public List<string> Gooditems;
    public List<string> Baditems;
    public List<string> Collectableitems;



    // Update is called once per frame
    void Start()
    {
        Gooditems = new List<string>();
        Baditems = new List<string>();
        Collectableitems = new List<string>();

    }

    
}


