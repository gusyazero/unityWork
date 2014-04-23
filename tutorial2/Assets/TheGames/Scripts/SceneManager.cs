using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameStart() {
		GameObject.FindWithTag("ScoreManager").SendMessage ("Init");
		Application.LoadLevel("TheGame");
	}

	public void GameInit() {
		Application.LoadLevel("Start");
	}

	public void GameEnd() {
		Application.LoadLevel("GameOver");
	}

}
