using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public float ballSpeed = 100; 
	public Rigidbody2D rigidbody;
		
	// Use this for initialization
	void Start () {
		Invoke ("GoBall", 2.0f);
	}

	void GoBall(){
		int randomNumber = Random.Range (0, 2);
		rigidbody = GetComponent<Rigidbody2D> ();
		if (randomNumber < 1) {
			rigidbody.AddForce(new Vector2(ballSpeed, -10));
		}
		else {
			rigidbody.AddForce(new Vector2(-ballSpeed, -10));
		}
	}

	public void ResetBall(){
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);
		transform.position = new Vector2 (0f, 2f);

		Invoke ("GoBall", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		// GetComponent<Rigidbody2D>().
	}

	void OnCollisionEnter2D (Collision2D collider){
		if (collider.collider.tag == "Player") {
			// Debug.Log("Its working!!!!");
			Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
			rigidbody.velocity = new Vector2(rigidbody.velocity.x, rigidbody.velocity.y/2 + collider.collider.attachedRigidbody.velocity.y/3);
		}

	
	}
}
