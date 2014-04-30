using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	// i put the "end" script under box collider2D in the seashore so that when the "player" hits the seashore the "endscene" appears!

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Player") {
			Application.LoadLevel ("EndScene");
		}
	}
}
