using UnityEngine;
using System.Collections;

public class GroundMover : MonoBehaviour {
		
	public float speed = -2.0f;

	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	
	}
}
