using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float accel = 1000.0f;

	private Vector3 screenPoint;
	private Vector3 offset;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce (transform.right * Input.GetAxisRaw ("Horizontal") * this.accel, ForceMode.Impulse);
	}

	private void OnMouseDown () {
		rigidbody.isKinematic = false;
		this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		//this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z));
	}
	
	private void OnMouseDrag () {
		//Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
		transform.position = currentPosition;
		if (transform.position.x > 7.5f) {
			transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
		}else if (transform.position.x < -7.5f) {
			transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
		}
	}
	
	private void OnMouseUp () {
		rigidbody.isKinematic = true;
	}
}
