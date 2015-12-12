using UnityEngine;
using System.Collections;

public class FlyMovement : MonoBehaviour {

	[SerializeField]
	private Transform center;

	private float flySpeed;

	// Use this for initialization
	void Start () {

		// the Random class is built in that has a method named range, range picks a value between 2 floats ...
		flySpeed = Random.Range (300f, 700f);
	}
	
	// Update is called once per frame
	void Update () {
		// makes the flys random ...
		transform.RotateAround (center.position, Vector3.up, flySpeed * Time.deltaTime);
	}
}
