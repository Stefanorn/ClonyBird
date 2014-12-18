using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour 
{
	int numBGPanels = 6;
	float pipeMax = 5.39f;
	float pipeMin = -4.15f;

	void Start()
	{
		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("pipe");
		foreach (GameObject pipe in pipes) 
		{
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range(pipeMin, pipeMax);
			pipe.transform.position = pos;

		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		float withOfBgObject = ((BoxCollider2D)col).size.x;

		Vector3 pos = col.transform.position;

		pos.x += withOfBgObject * numBGPanels;

		if (col.tag == "pipe") 
		{
			pos.y = Random.Range(pipeMin, pipeMax);
		}

		col.transform.position = pos;


	}
}
