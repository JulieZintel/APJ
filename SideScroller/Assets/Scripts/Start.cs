using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)){
			Application.LoadLevel("Main");

		}
	}
}
