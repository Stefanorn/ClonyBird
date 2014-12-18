using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour 
{
	void OnTriggerEnter2D( Collider2D col )
	{
		if (col.tag == "Player") 
		{
			Debug.Log("score");
			score.AddPoint();

		}
	}

}
