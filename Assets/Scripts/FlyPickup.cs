using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {

	void OnTriggerEnter (Collider other) {

		// if the collider "other" is tagged with "player"
		if (other.CompareTag ("Player")) {

			Destroy (gameObject);
		}

	}

}