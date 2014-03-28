using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	private int score = 0;
	private static bool isCreated = false;

	private void Awake() {
		if (ScoreManager.isCreated) {
			Destroy(this.gameObject);
		} else {
			DontDestroyOnLoad(this.gameObject);
			ScoreManager.isCreated = true;
		}
	}

	// Use this for initialization
	void Start () {
		this.Init();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore(int score) {
		this.score += score;
		//Debug.Log ("Score:" + this.score);
		UILabel label = GameObject.Find ("LabelScore").GetComponent<UILabel> ();
		label.text = "Score:" + this.score.ToString();
	}

	public int GetScore() {
		return this.score;
	}

	public void Init() {
		this.score = 0;
	}
}
