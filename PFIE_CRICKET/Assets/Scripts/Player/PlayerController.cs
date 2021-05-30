using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    //Taken from https://youtu.be/S2mK6KFdv0I (Interaction - Making an RPg in Unity(E01)) @6:40 onwards
    
    public LayerMask movementMask;
    Camera cam;
    PlayerMotor motor;
  
    public Interactable focus;
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();

    }

    /// Taken from https://youtu.be/9tePzyL6dgc (Interaction - Making an RPg in Unity(E02)) @2:18 onwards

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        
     
        // If we press left mouse 
        if (Input.GetMouseButtonDown(0))
        {
            // We cast a ray

            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
              //  motor.MoveToPoint(hit.point); // Move to where we hit

                RemoveFocus();

            }
        

            // If we press right mouse 
            if (Input.GetMouseButtonDown(1))
            {
            
                if (Physics.Raycast(ray, out hit, 100))
                {
                    Interactable interactable = hit.collider.GetComponent<Interactable>(); // If we did set it as our focus
                    if (interactable != null) // if it hits an interactable
                    {
                        SetFocus(interactable);

                    }
                }

            }
            void SetFocus(Interactable newFocus)
            {
                if (newFocus != focus)
                {
                    if (focus != null)
                        focus.OnDefocused();

                    focus = newFocus;
                    motor.FollowTarget(newFocus);

                }
                newFocus.OnFocused(transform);
            }

            void RemoveFocus()
            {
                if (focus != null)
                    focus.OnDefocused();

                focus = null;
               motor.StopFollowingTarget();
            }

        }

    }
}