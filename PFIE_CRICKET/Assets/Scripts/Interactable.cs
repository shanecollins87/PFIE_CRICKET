
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f; // how close player needs to be to interact with object
    void OnDrawGizmosSelected()

    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    public Transform interactionTransform;

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false; // this will prevent a constant log

    public virtual void Interact() // can call it from within this class, allows it to verwrite and each item different
    {
        //This method is meant to be over written
        Debug.Log("Interacting with" + transform.name);
    }

    void Update()

    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;

            }


        }

    }

    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;

    }

    public void OnDefocused() // the reverse
    {
        isFocus = false;
        player = null;
        hasInteracted = false;

    }


    void OnDrawGizmoSelected() // this shows it visually

    {
        if (interactionTransform == null)
            interactionTransform = transform;
        Gizmos.color = Color.yellow; // adds a colour
        Gizmos.DrawWireSphere(interactionTransform.position, radius);  // draws a sphere around the Interactable using a wireframe,  you can set the radius in Inspector

    }
}
