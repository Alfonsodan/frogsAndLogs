using UnityEngine;
using System.Collections;

public class FlySpawner : MonoBehaviour {

	[SerializeField]
	private GameObject FlyPrefab;

	// the maximum number of flies at any one time.
	[SerializeField]
	private int totalFlyMinimum = 12;

	// spawnArea ditermines how large of an area the flies will spwan at.
	private float spawnArea = 25f;

	// will be used in collection scores in later scripts. 
	public static int totalFlies;

	// Use this for initialization
	void Start () {
		totalFlies = 0;
	}
	
	// Update is called once per frame
	void Update () {

		// while the total number of flies is < the minimum...
		while (totalFlies < totalFlyMinimum) {
			totalFlies++;

			// create a random position for a fly
			float positionX =  Random.Range(-spawnArea, spawnArea);
			float positionZ =  Random.Range(-spawnArea, spawnArea);

			Vector3 flyPosistion = new Vector3(positionX, 2f, positionZ);

			// create a new fly..
			Instantiate(FlyPrefab, flyPosistion, Quaternion.identity);
		}
	}
}
