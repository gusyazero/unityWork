using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	protected float x = 0.0f;
	public float speed = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.x = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * this.x * this.speed	);
	}
}
