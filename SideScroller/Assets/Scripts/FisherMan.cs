﻿using UnityEngine;
using System.Collections;

public class FisherMan : MonoBehaviour {

	public float speed = 10.0f; // The speed of the hero, when it moves in the plane
	public static float score = 0;
	public Transform exp;
	public bool jump = false;			
	public float jumpForce = 10f;			
	private Transform groundDetector;		
	private bool grounded = false;

	void Start () {
		groundDetector = transform.Find("GroundDetector");
	}

	// Update is called once per frame
	void Update ()
	{	// Should keep the Hero to ground, so the gravity is attached to the scene and Fisherman not falls out(?)
		//grounded = Physics2D.Linecast (transform.position, groundDetector.position, 1 << LayerMask.NameToLayer ("Terrain"));  

		//Moving Hero forward with a speed of 5 floats
		if (Input.GetKeyDown (KeyCode.D)) {
			rigidbody2D.velocity = new Vector2 (5.0f, 0);
		}
		//Moving Hero backwards with a speed of 5 floats
		if (Input.GetKeyDown (KeyCode.A)) {
			rigidbody2D.velocity = new Vector2 (-5.0f, 0);
		}
		//Moving Hero forward with a extra speed of 10 floats
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigidbody2D.velocity = new Vector2 (10.0f, 0);
		}
		//SHOULD move Hero upwards with a height of 5 floats
		if (Input.GetKeyDown (KeyCode.W) && grounded) {
			//rigidbody2D.velocity = new Vector2 (0, 5.0f);
			jump = true;
		}
		/*	if (transform.position.y > 0) {
			rigidbody2D.velocity = new Vector2 (0, 0);
		}*/
	}
	void FixedUpdate ()
	{
		// If the player should jump...
		if(jump)
		{	
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}		

}

