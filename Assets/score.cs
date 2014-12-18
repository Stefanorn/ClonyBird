using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	static  int scoreTracker = 0;
	static int highScore = 0;

	static public void AddPoint()
	{
		if (scoreTracker > highScore) {
			highScore = scoreTracker;		
		}
	}
	
	// Update is called once per frame
	void Update () {

		guiText.text = "Score " + scoreTracker + "\nHighScore " + highScore;
	
	}
}
