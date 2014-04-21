using UnityEngine;
using System.Collections;

public class FisherMan : MonoBehaviour {
	private GameObject cameraRef;
	public float speed = 0.0f; // The speed of the hero, when it moves in the plane
	public static float score = 0;
	public Transform exp;
	private bool direction_right;
	private bool direction_left;
	private bool boost;

	private float boosttimer;
	public float boosttime = 5.0f;
	public float Jump = 0.0f;
	public bool isGrounded = true;
	public double ground_y = -1.136831;

	void Start () {
		cameraRef = GameObject.Find("MainCamera");

		boosttimer = boosttime;
		if (transform.position.y < ground_y && !isGrounded) {
			isGrounded = true;
		}
	}

	// Update is called once per frame
	void Update ()
	{
		cameraRef.transform.position = new Vector3(transform.position.x+5f, 1.6f, -10f);

		if (Input.GetKeyDown (KeyCode.D) && speed <15.0f) {

			speed += 1.0f;
		}
		if (Input.GetKeyDown (KeyCode.A) && speed < -15.0f) {

			speed -= 1.0f;
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			boost = true;
		}
		if (boost == true && boosttimer > 0.0f) {
			boosttimer -= 0.5f;
		} else {
			boost = false;
			boosttimer = boosttime;
		}

if (isGrounded && Input.GetKey (KeyCode.W)) {
	isGrounded = false;
			Jump = 20.0f;

		} else if (transform.position.y > ground_y && Jump > -20.0f  ) {
			Jump -= 0.5f;	
	transform.rigidbody2D.velocity = new Vector2 (speed, Jump);	

} else if (transform.position.y <= ground_y && !isGrounded){
	Jump = 0.0f;
	transform.rigidbody2D.velocity = new Vector2 (speed, Jump);
	isGrounded = true;
}
transform.rigidbody2D.velocity = new Vector2 (speed, Jump);
}

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
