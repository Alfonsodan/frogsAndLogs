using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private Animator playerAnimator;
	private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;
	private float turningSpeed = 20f;
	private Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {

		// Gather componants from the player game object
		playerAnimator = GetComponent<Animator> ();
		playerRigidbody = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		// gather input from the keyboard
		moveHorizontal = Input.GetAxisRaw("Horizontal");
		moveVertical = Input.GetAxisRaw("Vertical");

		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
	}

	void FixedUpdate () {

		// if the players movement vector doesnt = zero ...
		if (movement != Vector3.zero) {

			// ... than create a target rotation based on the movement vector ...
			Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

			// ... and create another rotation that moves from current rotation to target rotation ...
			Quaternion newRotation = Quaternion.Lerp(playerRigidbody.rotation, targetRotation, turningSpeed * Time.deltaTime);

			// ...and change the players rotation to the new incremental rotation ...
			playerRigidbody.MoveRotation(newRotation);

			// ... than play the jump animation ...
			playerAnimator.SetFloat ("Speed", 3f);
		} else {
			// ... otherwise dont play the jump animation ...
			playerAnimator.SetFloat ("Speed", 0f);
	}
	}
}
