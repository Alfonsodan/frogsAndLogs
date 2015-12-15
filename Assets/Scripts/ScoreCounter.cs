using UnityEngine;
using System.Collections;

// tell monodevelop to recognise the "Text" type, as it is not part of c#
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public static int score;
	private Text scoreCounterText;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreCounterText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreCounterText.text = score + " Flies";
	}
}
