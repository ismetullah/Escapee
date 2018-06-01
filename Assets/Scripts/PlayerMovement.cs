using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public float moveForce = 50f;
	public Rigidbody rb;

	// Update is called once per frame
	void Update ()
	{
		MovePlayer ();
	}

	private void MovePlayer ()
	{
		if (Input.GetKey ("w") || Input.GetKey ("up")) {
			rb.AddForce (0, 0, moveForce * Time.deltaTime, ForceMode.Impulse);
		}

		if (Input.GetKey ("s") || Input.GetKey ("down")) {
			rb.AddForce (0, 0, -moveForce * Time.deltaTime, ForceMode.Impulse);
		}

		if (Input.GetKey ("a") || Input.GetKey ("left")) {
			rb.AddForce (-moveForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
		}

		if (Input.GetKey ("d") || Input.GetKey ("right")) {
			rb.AddForce (moveForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
		}
	}
}
