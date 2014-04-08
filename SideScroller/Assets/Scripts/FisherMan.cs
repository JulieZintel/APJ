using System.Collections;
using UnityEngine;

public class FisherMan : MonoBehaviour {

	public int speed = 20;
	public float jumpSpeed = 13.0f;
	public float gravity = 0.0f;


	private Vector2 moveDirection = Vector2.zero;
	private CharacterController fisherMan;

<<<<<<< HEAD
	void Start (){
		fisherMan = GetComponent<CharacterController> ();
		if (!fisherMan)
			fisherMan = gameObject.AddComponent<CharacterController> ();
=======
		// Making movements options for my avatar - A for left, D for right, space for jump and S for duck and W for wide

		/*if(touchingPlatform && Input.GetButtonDown("Jump")){
			rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
		}
		distanceTraveled = transform.localPosition.x;
				if(Input.GetKeyDown(KeyCode.A)){
				rigidbody.AddForce(100.0f, 0, 0);
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			//		rigidbody.AddForce(0, 400.0f, 0);
		} */
>>>>>>> FETCH_HEAD

	}
	void Update () {
	

<<<<<<< HEAD
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
=======
		void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Shark"){

			score = score - 10;
			Instantiate (exp, transform.position, Quaternion.identity);
			Destroy(gameObject);
			// a function which makes the speed of R2D2 slower
>>>>>>> FETCH_HEAD

		if (Input.GetKeyUp ("Horizontal")) {
			speed = 20;
			jumpSpeed = 13.0f;
		}
<<<<<<< HEAD
		moveDirection.y -= gravity * Time.deltaTime;
		fisherMan.Move (moveDirection * Time.deltaTime);
	}
	void Move(){
		moveDirection = transform.position.x + speed;
=======
>>>>>>> FETCH_HEAD
	}
}