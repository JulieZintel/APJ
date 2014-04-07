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
			if(other.gameObject.name == "FisherMan") // If the shark and fisherman collide
			{
				//Instantiate (exp, transform.position, Quaternion.identity);
				Destroy(other.gameObject); // The shark disappears.
				score -= 10; // 10 points are subtracted from the final score. 
			}
		}
		
		/*void OnGUI(){
			GUI.Box(new Rect(100,100,100,100), "Score:" + score); // The player's score.
		}*/
	
	}