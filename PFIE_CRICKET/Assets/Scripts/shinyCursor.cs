
using System;
using System.Collections.Generic;
using UnityEngine;

// https://youtu.be/W4SE0_cfAqc I watch this to learn about changing cursor


public class shinyCursor : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D cursorStar;
    internal static CursorLockMode lockState;


    void Start()
    {
        // Cursor.visible = false; // this removes cursor from game
        Cursor.SetCursor(cursorArrow, Vector3.zero, CursorMode.ForceSoftware); // this forces software to change game currsor from standard to your choice
    }


    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorStar, Vector3.zero, CursorMode.ForceSoftware); // Add a box collider to the object once the cursor collides with it, it swaps out for your new one
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector3.zero, CursorMode.ForceSoftware); // Reverts back to normal out side the collider
    }

}
