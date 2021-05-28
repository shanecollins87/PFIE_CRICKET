using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallRock : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D cursorStar;

    void Start()
    {
        // Cursor.visible = false; // this removes cursor from game
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware); // this forces software to change game currsor from standard to your choice
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorStar, Vector2.zero, CursorMode.ForceSoftware); // Add a box collider to the object once the cursor collides with it, it swaps out for your new one
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware); // Reverts back to normal out side the collider
    }

}
