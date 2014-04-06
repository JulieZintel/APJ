using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

public static float score = 0f;
public Transform exp;

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
			score += 10; // A function which makes the fish disappear when it is hit by the fisherman. It also adds 10 points to the final score. 
	}
}
void OnGUI(){
	// Creates one with game over and the player's score:
	GUI.Box(new Rect(100,100,100,100), "Score:" + score);
}
}