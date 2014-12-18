using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour 
{
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapVelocity;
	public float maxSpeed = 5f;
	public float forwardSpeed = 1f;

	bool didFlap = false;

	// Use this for initialization
	void Start ()
	{
	
	}
	// Do Grahic & Inputs here
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) 
		{
			didFlap = true;
		}
	}
	
	// Dp Phinics engens updates here
	void FixedUpdate () 
	{
		velocity.x = forwardSpeed;

		if (didFlap == true) 
		{
			didFlap = false;
			if(velocity < 0)
				velocity = 0;
			velocity += flapVelocity;
		}

		velocity = Vector3.ClampMagnitude (velocity, maxSpeed);

		rigidbody2D.AddForce (velocity);

		float angle = 0;

		if (velocity.y < 0)
		{
			angle = Mathf.Lerp (0.0f, -90.0f, -velocity.y / maxSpeed);
		}
		transform.rotation = Quaternion.Euler (0, 0, angle);
	}
}
