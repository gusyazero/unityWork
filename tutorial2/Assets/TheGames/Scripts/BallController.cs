using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float startSpeed = 20.0f;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce ((transform.forward + transform.right) * this.startSpeed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void FixedUpdate () {
		rigidbody.angularVelocity = Vector3.Normalize (rigidbody.angularVelocity);
	}
}
