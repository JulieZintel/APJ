using UnityEngine;
using System.Collections;

public class Message : MonoBehaviour {

	public static float score = 0f;
	public Transform exp;
	public static float speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void Update () {

	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "FisherMan")
		{
			Instantiate (exp, transform.position, Quaternion.identity);
			Destroy(gameObject);
			score += 20; // A function which makes the message dissapear when it is hit  by the fisherman. It also adds twenty points to the final score. 
		}
	}
	void OnGUI(){
		// Creates one with game over and the player's score:
		GUI.Box(new Rect(100,100,100,100), "Score:" + score);
	}
}