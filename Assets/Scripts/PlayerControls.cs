using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	// Use this for initialization
	public KeyCode moveUp;
	public KeyCode moveDown;

	private Rigidbody2D myRigidbody;

	public float Speed = 10f;

	void Start() {
		myRigidbody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (moveUp)) 
		{
			myRigidbody.velocity = new Vector3(0, Speed, 0);
		} 
		else if (Input.GetKey (moveDown)) 
		{
			myRigidbody.velocity = new Vector3(0, -Speed, 0);
		} 
		else 
		{
			myRigidbody.velocity = new Vector3(0, 0, 0);
		}

	}
}
