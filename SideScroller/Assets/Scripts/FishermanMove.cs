using UnityEngine;
using System.Collections;

public class FishermanMove : MonoBehaviour{
	public float f_speed = 10.0f;
		public float f_jumpSpeed;
	public float f_gravity = 20.0f;
		private Vector3 v3_moveDirection = Vector3.zero;
	private CharacterController FisherMan;

		void Awake ()
		{
		FisherMan = GetComponent<CharacterController>();//this.GetComponent();
		}

		void Update ()
		{
		if (FisherMan.isGrounded) {
			// Calculate how fast we should be moving
			Vector3 targetVelocity = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			targetVelocity = transform.TransformDirection (targetVelocity);
			targetVelocity *= f_speed;
		}
		if (FisherMan.isGrounded)
			{ 
				v3_moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
				v3_moveDirection *= f_speed;

			if (Input.GetKeyDown("Jump"))
				{
					v3_moveDirection.y = f_jumpSpeed;
				}
			}

			v3_moveDirection.y -= f_gravity * Time.deltaTime;
		FisherMan.Move(v3_moveDirection * Time.deltaTime);
		}

	}
	/*		public float speed = 10.0f;
		public float gravity = 10.0f;
		public float maxVelocityChange = 10.0f;
		public bool canJump = true;
		public float jumpHeight = 2.0f;
		private bool grounded = false;



		void Awake () {
			rigidbody.freezeRotation = true;
			rigidbody.useGravity = false;
		}

		void FixedUpdate () {
			if (grounded) {
				// Calculate how fast we should be moving
			Vector2 targetVelocity = new Vector2(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
				targetVelocity = transform.TransformDirection(targetVelocity);
				targetVelocity *= speed;

				// Apply a force that attempts to reach our target velocity
			Vector2 velocity = new Vector2();
			Vector2 = rigidbody2D.velocity;
			Vector2 velocityChange = (targetVelocity - velocity);
				velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
				velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
				velocityChange.y = 0;
			rigidbody2D.AddForce(velocityChange, ForceMode.VelocityChange);

				// Jump
				if (canJump && Input.GetButton("Jump")) {
				rigidbody2D.velocity = new Vector2(velocity.x, CalculateJumpVerticalSpeed(), velocity.z);
				}
			}

			// We apply gravity manually for more tuning control
		rigidbody2D.AddForce(new Vector2 (0, -gravity * rigidbody.mass,0));

			grounded = false;
		}

		void OnCollisionStay () {
			grounded = true;    
		}

		float CalculateJumpVerticalSpeed () {
			// From the jump height and gravity we deduce the upwards speed 
			// for the character to reach at the apex.
			return Mathf.Sqrt(2 * jumpHeight * gravity);
		}
	}

	/*	public float speed = 10.0f; // The speed of the hero, when it moves in the plane
	public static float score = 0;
	public Transform exp;	
	float gravity = 5;
	bool playerFlying;


	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

		rigidbody2D.velocity = new Vector2 (10, 0);

		// Making movements options for my avatar - A for left, D for right, space for jump and S for duck and W for wide

		if (Input.GetKeyDown (KeyCode.A)) {
			rigidbody.AddForce (100.0f, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigidbody.AddForce (0, 200.0f, 0);
		} 

		// In Update():
		if (KeyDown.Space() && !playerFlying) { playerFlying = true && speed == 50;}
		playerY += speed;
		speed -= gravity;
		if (playerCollidesWithFloor())
		{
			currentYspeed = 0; // We came back to ground.
			playerFlying = false;
		}
		else if (playerCollidesWithSomethingElse())
		{
			speed = 0; // We hit obstacle in-air.
		}
	}
	}
		
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Shark"){

			score = score - 10;
			Instantiate (exp, transform.position, Quaternion.identity);
			Destroy(gameObject);
			// a function which makes the speed of R2D2 slower

		}else if(other.gameObject.name == "Fish"){
			score = score + 10;
			Instantiate (exp, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}*/
	// Use this for initialization
	