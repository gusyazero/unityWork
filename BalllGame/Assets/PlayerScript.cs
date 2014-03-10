using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	protected float x = 0.0f;
	public float speed = 0.2f;

	private Vector3 screenPoint;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.x = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * this.x * this.speed	);
	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Enemy(Clone)") {
			float localX = Random.Range(0.1f, 0.5f);
			transform.localScale -= new Vector3(localX, 0.0f, 0.0f);
			if (transform.localScale.x < 1.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f); 
		}
	}

	private void OnMouseDown () {
		this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	private void OnMouseDrag () {
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
		transform.position = currentPosition;
	}
}
