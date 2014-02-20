using UnityEngine;
using System.Collections;

public class BallBoxScript : MonoBehaviour {

	public GameObject prefab;
	public int ballCnt = 0;
	public int ballMax = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump")) {
			Instantiate(this.prefab, Vector3.up * 10, Quaternion.identity);
			this.ballCnt++;
		}

		if (this.ballCnt > this.ballMax) {
			Application.LoadLevel("GameOver");
		}
	}
}
