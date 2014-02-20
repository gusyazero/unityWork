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

	public void OnGUI() {
		GUI.Label(new Rect(10, 10, 200, 50), "Game Over", this.style);
	}

}
