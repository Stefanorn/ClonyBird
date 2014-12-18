using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour 
{
	Vector3 velocity;
	public float flapSpeed = 12f;
	float forwardSpeed = 11f;

	bool didFlap = false;
	bool dead = false;
	public bool GodMode = false;
	Animator animator;

	// Use this for initialization
	void Start ()
	{
		animator = transform.GetComponentInChildren<Animator> ();
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
		if (dead)
						return;

		rigidbody2D.AddForce (Vector2.right * forwardSpeed);

		if (didFlap) 	
		{
			rigidbody2D.AddForce (Vector2.up * flapSpeed);
			didFlap = false;
			animator.SetTrigger("Doflap");

		}
		if(rigidbody2D.velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {
			float angle = Mathf.Lerp (0, -90, (-rigidbody2D.velocity.y / 30.0f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}
	}
	void OnCollisionEnter2D()
	{
		if (GodMode) {
			return;
		}
		animator.SetTrigger ("Dead");
		dead = true;
	}
}
