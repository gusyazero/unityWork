using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0.0f, 0.0f, -0.1f, Space.World);
		transform.Rotate(1, 1, 1);

		if (transform.position.z <= -12.0) {
			//Application.LoadLevel("GameOver");
		}
	}

	void OnCollisionEnter () {
		Destroy(gameObject);
	}
}
