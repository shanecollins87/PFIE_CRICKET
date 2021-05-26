using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

    // public Interactable focus; //// Taken from https://youtu.be/9tePzyL6dgc (Interaction - Making an RPg in Unity(E02)) @2:18 onwards

    public float speed = 5;
    public float MovementSpeed = 1;
    public float jumpPower = 2;
    public float jumpTime = 2;
    public float jumpForce = 20; //Jumping speed

    private Rigidbody rb;
    private CapsuleCollider col;

    //flag to keep track of key pressing
    bool pressedJump = false;


    NavMeshAgent agent; // https://youtu.be/kQiTRKMrl5s

    private void OnTriggerEnter(Collider other)

    {
        Debug.Log("Object Was Eaten");

    }

    // Use this for initialization
    void Start()
    {

        agent = GetComponent<NavMeshAgent>(); // Calls the Nav Mesh

        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }


    // Update is called once per frame
    //void FixedUpdate()
    //{

    //    JumpHandler();

    //}

    //// takes care of the jumping logic
    //void JumpHandler()
    //{
    //    // Input on the Jump axis
    //    float jAxis = Input.GetAxis("Jump");

    //    // If the key has been pressed
    //    if (jAxis > 0)
    //    {


    //        //make sure we are not already jumping
    //        if  (pressedJump = true);
    //        { 

    //            //jumping vector
    //            Vector3 jumpVector = new Vector3(0, jAxis * jumpForce, 0);

    //            //apply force
    //            rb.AddForce(jumpVector, ForceMode.VelocityChange);
    //        }
    //    }
    //    else
    //    {
    //        //set flag to false
    //        pressedJump = false;
    //    }
    //}






    // Update is called once per frame
    void Update()
    {

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //Get the input value from the controllers
        float Horizontal = Input.GetAxis("Horizontal") * speed;
        float Vertical = Input.GetAxis("Vertical") * speed;

        Horizontal *= Time.deltaTime;
        Vertical *= Time.deltaTime;
        //Translate our character via our inputs.
        transform.Translate(Horizontal, 0, Vertical);



        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector3(0, jumpForce), (ForceMode)ForceMode2D.Impulse);
        }


        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;


        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }

        }
        //// Taken from https://youtu.be/9tePzyL6dgc (Interaction - Making an RPg in Unity(E02)) @2:18 onwards
     

        //// If we press left mouse 
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // We cast a ray

        //    RaycastHit hit;
        //    Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out hit, 100, movementMask))
        //    {
        //        motor.MoveToPoint(hit.point); // Move to where we hit

        //        RemoveFocus();

        //    }

        //    // If we press right mouse 
        //    if (Input.GetMouseButtonDown(1))
        //{
        //  // We cast a ray

        //    RaycastHit hit;
        //    Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out hit, 100))
        //    {
        //        Interactable interactable = hit.collider.GetComponent<Interactable>(); // If we did set it as our focus
        //        if (inteactable != null) // if it hits
        //        {
        //            SetFocus(interactable);

        //        }
        //    }

        //}
        //    void SetFocus (Interactable newFocus)
        //{
        //    focus = newFocus;
        //}

        //    void RemoveFocus ()
        //    {

        //        focus = null;
        //    }


    }
}



