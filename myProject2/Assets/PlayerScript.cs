using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	protected float x = 0.0f;

	// Use this for initialization
	public void Start () {

	}
	
	// Update is called once per frame
	public void Update () {
		this.x = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * this.x);
	}

	public void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.name == "RightWall") {
			Debug.Log("Right");
		}
	}
}
