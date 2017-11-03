using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMentScript : MonoBehaviour {
	public float speed;

	//private Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		//rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float movehorizontal = Input.GetAxis("Horizontal");

		transform.Translate (speed * Time.deltaTime, 0.0f, movehorizontal);
	}
}
