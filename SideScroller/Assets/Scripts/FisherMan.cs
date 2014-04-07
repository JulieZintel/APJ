using System.Collections;
using UnityEngine;

public class FisherMan : MonoBehaviour {

	public float speed = 10.0f; // The speed of the hero, when it moves in the plane
	public static float score = 0;
	public Transform exp;	
	public Vector3 jumpVelocity;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody2D.velocity = new Vector2(7,0);

		// Making movements options for my avatar - A for left, D for right, space for jump and S for duck and W for wide

		if(touchingPlatform && Input.GetButtonDown("Jump")){
			rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
		}
		distanceTraveled = transform.localPosition.x;
	/*			if(Input.GetKeyDown(KeyCode.A)){
				rigidbody.AddForce(100.0f, 0, 0);
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			//		rigidbody.AddForce(0, 400.0f, 0);
		} */

	}

	/*	void OnCollisionEnter(Collision other){
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
}