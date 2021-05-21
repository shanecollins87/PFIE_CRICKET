using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float MovementSpeed = 1;
    public float jumpPower = 2;
    public float jumpTime = 2;
    public float JumpForce = 20;

    private Rigidbody rb;
    private CapsuleCollider col;

      NavMeshAgent agent; // https://youtu.be/kQiTRKMrl5s

    private void OnTriggerEnter(Collider other)

    {
        Debug.Log("Hit detected");

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
            rb.AddForce(new Vector3(0, JumpForce), (ForceMode)ForceMode2D.Impulse);
        }


        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        ///*
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
            //*/
        }


    }
}


