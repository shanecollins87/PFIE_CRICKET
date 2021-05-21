using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuinCrate : MonoBehaviour
{

	[Header("Visuals")]
	public GameObject container;
	public float rotationSpeed;


	[Header("Gameplay")]
	public int ruin = 1;

	void Start()
	{

		rotationSpeed = 180f;

	}

	void Update()
	{
		container.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); // this code will make the Ruincrate rotate

		transform.Rotate(0, rotationSpeed, 1);

		
	 
	}
}






