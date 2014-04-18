using UnityEngine;
using System.Collections;

public class FisherMan : MonoBehaviour {

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
		boosttimer = boosttime;
		if (transform.position.y < ground_y && !isGrounded) {
			isGrounded = true;
		}
	}

	// Update is called once per frame
	void Update ()
	{



		/*if (Input.GetKeyDown (KeyCode.D)) {
			direction_right = true;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			direction_left = true;
		}*/
		if (Input.GetKeyDown (KeyCode.D) && speed <15.0f) {

			speed += 1.0f;
		}
		if (Input.GetKeyDown (KeyCode.D) && speed < -15.0f) {

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

		/*if (direction_right == true && boost == false) {
			rigidbody2D.AddForce (transform.right * speed);
			direction_right = false;
		} else if (direction_right == true && boost == true) {
			rigidbody2D.AddForce (transform.right * speed);
			direction_right = false;
		}
<<<<<<< HEAD

		if (direction_left == true && boost == false) {
			rigidbody2D.AddForce (-transform.right * speed);
			direction_left = false;
		} else if (direction_left == true && boost == true) {
			rigidbody2D.AddForce (-transform.right * speed);
			direction_left = false;
		}*/
		/*	if (Input.GetKeyDown (KeyCode.W) && transform.position.y < (-7.0f) ) {
		//	rigidbody2D.velocity = new Vector2 (0, 5.0f);

		rigidbody2D.AddForce(transform.up*100*Jump);
	}*/
	/*	if(isGrounded && Input.GetKey(KeyCode.W)) {
	if (transform.position.y > 0) {
		rigidbody2D.AddForce (transform.up*100 * Jump);
	}}*/
/// <summary>
/// reset y pos til ground, y-vel til 0
/// </summary>
if (isGrounded && Input.GetKey (KeyCode.W)) {
	isGrounded = false;
	//rigidbody2D.AddForce (transform.up * 5 * Jump);
	Jump = 5.0f;

} else if (transform.position.y > ground_y && Jump > -5.0f  ) {
	Jump -= 1.0f;	
	transform.rigidbody2D.velocity = new Vector2 (speed, Jump);	
	//transform.rigidbody2D.AddForce (transform.up * -5);
} else if (transform.position.y <= ground_y && !isGrounded){
	Jump = 0.0f;
	transform.rigidbody2D.velocity = new Vector2 (speed, Jump);
	isGrounded = true;
}
transform.rigidbody2D.velocity = new Vector2 (speed, Jump);
}

}
=======
	}
>>>>>>> FETCH_HEAD

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
