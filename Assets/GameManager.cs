using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	static int playerScore01 = 0;
	static int playerScore02 = 0;

	public GUISkin theSkin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public static void Score (string wallName) {
		if (wallName == "rightWall") {
			playerScore01++;
		} else {
			playerScore02++;
		}
		Debug.Log ("Player 1 Score is " + playerScore01);
		Debug.Log ("Player 2 Score is " + playerScore02);
	}

	void OnGUI(){
		GUI.skin = theSkin;
		GUI.Label (new Rect (Screen.width / 2 - 150 - 12, 25, 100, 100), "" + playerScore01);
		GUI.Label (new Rect (Screen.width / 2 + 150 - 12, 25, 100, 100), "" + playerScore02);
	}
}
