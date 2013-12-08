using UnityEngine;
using System.Collections;

public class tapHandler : MonoBehaviour {
	
	public static float gravity = 20.0f;
	public static float jumpSpeed = 8.0f;
	public static float hitRange = 1.0f;
	
	private Vector3 velocity;
	private bool beingGrounded;
	private bool isStart;
	private float groundedAt;

	// Use this for initialization
	private void Start () {
		this.beingGrounded = false;
		this.isStart = false;
		this.groundedAt = 0.0f;
	}
	
	// Update is called once per frame
	private void Update () {
		if (Input.GetButtonDown("Jump")){
			if (this.beingGrounded == true &&
				(Time.time - this.groundedAt) <= hitRange) {
				rigidbody.AddForce(transform.up * jumpSpeed, ForceMode.Impulse);
				this.beingGrounded = false;
			} else {
				rigidbody.AddForce(-1*(transform.up * gravity), ForceMode.Impulse);
				this.isStart = true;
			}
			print(this.groundedAt.ToString() + ':' + Time.time.ToString());
		} else if (this.isStart != true) {
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "HitZone") {
			this.beingGrounded = true;
			this.groundedAt = Time.time;
		}
	}
	
	private void OnTriggerStay(Collider other)
	{
		if(other.gameObject.tag == "HitZone") {
			this.beingGrounded = true;
			//this.groundedAt = Time.deltaTime;
		}
	}
	
	private void OnTriggerExit(Collider other) 
	{
		if(other.gameObject.tag == "HitZone") {
			this.beingGrounded = false;
			this.groundedAt = 0.0f;
		}
	}
	
	private void OnCollisionEnter(Collision Collision) {
		if (Collision.gameObject.tag == "Plane") {
			this.beingGrounded = true;
			//this.groundedAt = Time.deltaTime;
		}
	}
	
	private void OnGUI()
	{
		GUILayout.Label(Time.deltaTime.ToString());
	}
	
	
}
