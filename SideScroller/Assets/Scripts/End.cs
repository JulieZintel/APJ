using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// here i put this function in a file apart and not at the fisher man file like it was before ( creating an error)
		// i put the "end" script under box collider2D in the seashore so that when the "player" hits the seashore the "endscene" appears!
	
	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Player") {
			Debug.Log ("asdfghjk");
			Application.LoadLevel ("EndScene");

		}
	}
}
