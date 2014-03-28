using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

	public int score = 10;
	public GameObject destroyPrefab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnCollisionEnter(Collision collision) {
		GameObject.FindWithTag("ScoreManager").SendMessage ("AddScore", this.score);
		//Destroy (collision.gameObject);
		Destroy (this.gameObject);
		Instantiate (this.destroyPrefab, transform.position, transform.rotation);
	}
}
