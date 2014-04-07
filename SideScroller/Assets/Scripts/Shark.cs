using UnityEngine;
using System.Collections;

public class Shark : MonoBehaviour {
	
		public static float score = 0f;
		public static float speed;
		//public Transform exp;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame

		void Update () {

		}
		void OnCollisionEnter2D(Collision2D other){
			if(other.gameObject.name == "FisherMan")
			{
				//Instantiate (exp, transform.position, Quaternion.identity);
				Destroy(gameObject);
				score -= 10; // A function which makes the shark dissapear when it is hit by the fisherman. It also subtracts 10 points from the final score. 
			}
		}
		void OnGUI(){
			// Creates one with game over and the player's score:
			GUI.Box(new Rect(100,100,100,100), "Score:" + score);
		}
	}