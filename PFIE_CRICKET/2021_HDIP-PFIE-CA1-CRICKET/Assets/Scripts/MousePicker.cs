using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MousePicker : MonoBehaviour
{
    public Camera currentCamera;

    // Start is called before the first frame update
    private void Start()
    {
        currentCamera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit hit;
        Ray ray = currentCamera.ScreenPointToRay(Input.mousePosition);

        Debug.Log(ray);

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit))
        {

#if UNITY_EDITOR
            Debug.Log(ray);
#endif
            Transform objectHit = hit.transform;
            objectHit.gameObject.GetComponent<Renderer>().material.color = Color.clear;
        }
    }
}