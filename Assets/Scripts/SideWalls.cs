using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {
		
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name == "Ball") {
		    if (transform.name == "rightWall")
		    {
		        GetComponent<AudioSource>().panStereo = 0.85f;
		    } else
                GetComponent<AudioSource>().panStereo = -0.85f;
            GetComponent<AudioSource>().Play();
			GameManager.Score (transform.name);
			hitInfo.gameObject.SendMessage("ResetBall");
		}
	}
}
