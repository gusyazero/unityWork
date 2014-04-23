using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ScoreManager obj = GameObject.FindWithTag ("ScoreManager").GetComponent<ScoreManager> ();
		if (obj) {
			UILabel label = GameObject.Find ("LabelScoreResult").GetComponent<UILabel> ();
			int score = obj.GetScore();
			label.text = "Result:" + score.ToString();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
