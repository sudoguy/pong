using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	// Use this for initialization
	public KeyCode moveUp;
	public KeyCode moveDown;

	public bool AI = false;

	private Rigidbody2D myRigidbody;

	private Transform Ball;

	public float Speed = 10f;

	void Start() {
		myRigidbody = GetComponent<Rigidbody2D> ();
		Ball = GameObject.FindGameObjectWithTag("Ball").transform; 
	}

	// Update is called once per frame
	void Update () {
	
		if (!AI) {
			if (Input.GetKey (moveUp)) {
				myRigidbody.velocity = new Vector3 (0, Speed, 0);
			} else if (Input.GetKey (moveDown)) {
				myRigidbody.velocity = new Vector3 (0, -Speed, 0);
			} else {
				myRigidbody.velocity = new Vector3 (0, 0, 0);
			}
		} else {
			if (Ball.position.y > this.transform.position.y + 1){
				myRigidbody.velocity = new Vector3(0, Speed, 0);
			} else if (Ball.position.y < this.transform.position.y - 1){
				myRigidbody.velocity = new Vector3(0, -Speed, 0);
			}
		}
	}
}
