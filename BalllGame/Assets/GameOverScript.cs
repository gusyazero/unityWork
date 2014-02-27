using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	public GUIStyle style;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.Label(new Rect(10, 10, 100, 100), "Game Over", this.style);
	}
}
