using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

	public Camera mainCam;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;
	
	public Transform Player01;
	public Transform Player02;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Move each wall to its edge location:
		
		topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
		topWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3(0f, Screen.height, 0f)).y + 0.5f);
		
		bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
		bottomWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3(0f, 0, 0f)).y - 0.5f);

		leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f , Screen.height * 2f, 0f)).y);
		leftWall.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
		
		rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
		rightWall.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

		Player01.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, Player01.position.y);
		Player02.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, Player02.position.y);

	}
}
