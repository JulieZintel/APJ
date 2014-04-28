using UnityEngine;
using System.Collections;

public class FisherMan : MonoBehaviour {
	private GameObject cameraRef; // The camera that's controlling the gameplay
	private static float score = 0; // The score system
	private float speed = 0.0f; // The speed of the hero, when it moves in the plane

	private float Jump = 0.0f;
	private bool isGrounded = true;
	private double ground_y = -1.136831;

	void Start () {
		cameraRef = GameObject.Find("MainCamera");

		if (transform.position.y < ground_y && !isGrounded) {
			isGrounded = true;
		}
	}

	// Update is called once per frame
	void Update ()
	{
		// Tracks The Fisherman on only the x-axis, so the player can see if the Fisherman is hitting any obstacles
		cameraRef.transform.position = new Vector3(transform.position.x+5f, 1.6f, -10f);

		// Speed forwards when D is pressed, speed is increased when D is pressed multiple times
		if (Input.GetKeyDown (KeyCode.D) && speed <15.0f) {
			speed += 1.0f;
		}

		// Speed backwards when A is pressed, speed is increased when D is pressed multiple times
		if (Input.GetKeyDown (KeyCode.A) && speed > -15.0f) {
			speed -= 1.0f;
		}

		// The speed will have a speedboost as soon Space is pressed
		if (Input.GetKeyDown (KeyCode.Space)) { 
			if (speed < 0.0f) {
				speed -= 5.0f;
			}
			if (speed > 0.5f) {
				speed += 5.0f;
			}}
		// The speed will drop, so it's not the same speed all the time
		if (speed < 0.0f) {
			speed += 0.05f;
		}else if (speed > 0.0f) {
			speed -= 0.05f;
		}

		// The Hero can jump to avoid any obstacles by pressing W
		if (isGrounded && Input.GetKey (KeyCode.W)) {
			isGrounded = false;
			Jump = 20.0f;

		// When Hero jump he needs to fall down again, by the gravity
		} else if (transform.position.y > ground_y && Jump > -20.0f  ) {
			Jump -= 0.5f;	
		transform.rigidbody2D.velocity = new Vector2 (speed, Jump);	

		//When Hero is in the air jumping, the hero cannot jump again, before it's down at the ground.
		} else if (transform.position.y <= ground_y && !isGrounded){
			Jump = 0.0f;
			transform.rigidbody2D.velocity = new Vector2 (speed, Jump);
			isGrounded = true;
		}
		transform.rigidbody2D.velocity = new Vector2 (speed, Jump);
		}

	// Function to the Scoresystem when Hero hits an obstacle
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.name == "Fish") // If the fish and fisherman collide
		{
			Destroy(other.gameObject); // Destroys the fish.
			score += 1; // 1 point is added to the score.
		}
		else if(other.gameObject.name == "Message") // If the message and fisherman collide
		{
			Destroy(other.gameObject); // Destroys the message.
			score += 1; // 1 point is added to the score.
		}
		
		else if(other.gameObject.name == "Shark") // If the shark and fisherman collide
		{
			Destroy(other.gameObject); // Destroys the shark.
			score -= 5; // 5 points are subtracted from the score.
		}
	}
	
	void OnGUI(){
		GUI.Box(new Rect(10,10,100,20), "Score:" + score); // Displays the score in the corner.
	}
}
