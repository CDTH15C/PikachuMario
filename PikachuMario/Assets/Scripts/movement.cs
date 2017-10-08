using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float speed, jumpSpeed;
	public Rigidbody2D player;
	public Animator anim;
	private bool grounded;

	//
	public Transform groundedRayEnd;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.DrawLine (this.transform.position, groundedRayEnd.position, Color.green);
		grounded = Physics2D.Linecast (this.transform.position, groundedRayEnd.position, 1 << LayerMask.NameToLayer ("ground"));

		Move ();
		Jump ();

		anim.SetFloat ("speed", Mathf.Abs(player.velocity.x));
		anim.SetFloat ("speed y", player.velocity.y);
		anim.SetBool ("grounded", grounded);
		
	}
	void Move()
	{
		float dir_x = Input.GetAxisRaw ("Horizontal");
		player.velocity = new Vector2 (speed * dir_x, player.velocity.y);

		if (dir_x != 0) {
			Vector3 temp = transform.localScale;
			temp.x = dir_x;
			transform.localScale = temp;
		}
	}

	void Jump()
	{
		if (grounded) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				grounded = false;
				player.velocity = new Vector2 (player.velocity.x, jumpSpeed);
			}
		}
	}
}
