using System.Collections;
using UnityEngine;

public class FisherMan : MonoBehaviour {

	public int speed = 20;
	public float jumpSpeed = 13.0f;
	public float gravity = 0.0f;


	private Vector2 moveDirection = Vector2.zero;
	private CharacterController fisherMan;

	void Start (){
		fisherMan = GetComponent<CharacterController> ();
		if (!fisherMan)
			fisherMan = gameObject.AddComponent<CharacterController> ();

	}
	void Update () {
	

		if (fisherMan.isGrounded) {
			moveDirection = new Vector2 (Input.GetAxis ("Horizontal"), 0);
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;

			if (Input.GetKeyDown ("Jump")) {
				moveDirection.y = jumpSpeed;
			}
			if (Input.GetKeyDown ("Horizontal")) {
				speed = 30;
				jumpSpeed = 15.0f;
			}
		}

		if (Input.GetKeyUp ("Horizontal")) {
			speed = 20;
			jumpSpeed = 13.0f;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		fisherMan.Move (moveDirection * Time.deltaTime);
	}
	void Move(){
		moveDirection = transform.position.x + speed;
	}
}