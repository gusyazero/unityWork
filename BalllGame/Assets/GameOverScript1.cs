using UnityEngine;
using System.Collections;

public class GameOverScript1 : MonoBehaviour {

	public GUIStyle style;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI () {
		GUI.Label(new Rect(10, 10, 100, 30), "Game Over!", this.style);
	}
}
