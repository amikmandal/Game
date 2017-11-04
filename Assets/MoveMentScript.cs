using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveMentScript : MonoBehaviour 
{
	public float speed;

	private float jump = 10f;

	private float acceleration = 5f;

	private float Velocity;

	//private float hello;

	//public LayerMask groundLayer;

	//public BoxCollider col;

	public Boolean IsJumping;

	Vector3 movement;

	//private Vector3 moveDirection = Vector3.zero;

	private Rigidbody rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		IsJumping = false;

		//col = GetComponent<BoxCollider> ();
	}

	void FixedUpdate ()
	{

		float moveHorizontal = Input.GetAxisRaw ("Horizontal");

		Velocity = speed + (acceleration * Time.deltaTime);
	
		movement.Set (Velocity * Time.deltaTime, 0.0f, -moveHorizontal);

		movement = movement.normalized * Velocity * Time.deltaTime;

		rb.MovePosition (transform.position + movement);
	
		if (Input.GetKeyDown (KeyCode.Space) && IsJumping == false) {
			//hello = rb.position.y;
			rb.AddForce (Vector3.up * jump, ForceMode.Impulse);
			IsJumping = true;
		}


	}
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.CompareTag ("Ground")) 
		//if(rb.position.y == hello)
		{
			IsJumping = false;
			//hello = -1;
		}
	}

}
