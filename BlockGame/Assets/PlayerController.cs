using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float pos = 0f;
	Animator animator;
	float speed = 0f;
	int direction = 0;

	public Vector3 targetDirection;

	// Use this for initialization
	void Start () {
		pos = 0f;
		speed = 0f;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//UpdateMovement();

		targetDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		
		if (Input.GetButton ("Fire1")) {
			this.OnAttack ();
		} else if (targetDirection.magnitude > 0.1) {
			// プレイヤーの向きを変えて
			transform.rotation = Quaternion.LookRotation (targetDirection);
			// 移動
			this.AddSpeed (0.01f);
		} else {
			this.OnStop();
		}
	}

	void AddSpeed(float delta)
	{
		speed = Mathf.Clamp( speed + delta, -1f, 1f);
		animator.SetFloat("Speed", speed);
	}
	
	void SetSpeed(float spd)
	{
		speed = spd;
		animator.SetFloat("Speed", speed);
	}
	void OnAttack()
	{
		animator.SetTrigger("Attack");
	}
	void OnJump()
	{
		animator.SetTrigger("Jump");
	}
	void OnStop()
	{
		SetSpeed(0f);
	}
	
	void UpdateMovement()
	{
		if (direction != 0) AddSpeed(direction * 0.01f);
		
		pos += speed * Time.deltaTime;
	}
	
}
