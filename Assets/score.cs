using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {

	static  int scoreTracker = 0;
	static int highScore = 0;
	static bool isDead = false;

	Text textBox;
	BirdMovement bird;
	void Start()
	{
		bird = GameObject.FindGameObjectWithTag ("Player").GetComponent<BirdMovement> ();
		scoreTracker = 0;
		textBox = GetComponent <Text> ();
		highScore = PlayerPrefs.GetInt ("highScore", 0);
	}

	static public void AddPoint()
	{
		if (isDead) 
			return;
		
		scoreTracker++;
		if (scoreTracker > highScore) {
			highScore = scoreTracker;
		}
	}
	void OnDestroy()
	{
		PlayerPrefs.SetInt ("highScore", highScore);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (bird);
		textBox.text = "Score " + scoreTracker + "\nHighScore " + highScore;
		if (bird.dead) {
			isDead = true;
	} 
		else {
			isDead = false;
		}
	
	}
}
