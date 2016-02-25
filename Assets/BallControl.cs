using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {


	public Rigidbody2D rigidbody;
		
	// Use this for initialization
	void Start () {
		int randomNumber = Random.Range (0, 2);
		rigidbody = GetComponent<Rigidbody2D> ();
		if (randomNumber < 1) {
			// Debug.Log("Shoot right!");
			// Debug.Log(randomNumber.ToString());
			rigidbody.AddForce(new Vector2(80, 10));
		}
		else {
			// Debug.Log("Shoot left!");
			// Debug.Log(randomNumber.ToString());
			rigidbody.AddForce(new Vector2(-80, -10));
		}

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
