public class FisherMan : MonoBehaviour {

	public float speed = 10.0f; // The speed of the hero, when it moves in the plane
	public static float score = 0;
	public Transform exp;

	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.D)) {
			rigidbody2D.velocity = new Vector2 (5.0f, 0);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			rigidbody2D.velocity = new Vector2 (10.0f, 0);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			rigidbody2D.velocity = new Vector2 (0, 5.0f);
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			rigidbody2D.velocity = new Vector2 (0, -5.0f);
		}

	}

}
void OnCollisionEnter(Collision other){
	if (other.gameObject.name == "Shark"){

		score = score - 10;
		Instantiate (exp, transform.position, Quaternion.identity);
		Destroy(gameObject);


	}else if(other.gameObject.name == "Fish"){
		score = score + 10;
		Instantiate (exp, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
}

