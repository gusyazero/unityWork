using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float speed =  0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0.0f, 0.0f, -0.2f, Space.World);
		transform.Rotate(1, 1, 1);
	}
}
