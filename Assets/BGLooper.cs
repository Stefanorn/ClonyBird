using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour 
{
	int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D col)
	{
		float withOfBgObject = ((BoxCollider2D)col).size.x;

		Vector3 pos = col.transform.position;

		pos.x += withOfBgObject * numBGPanels - withOfBgObject/2f;

		col.transform.position = pos;


	}
}
