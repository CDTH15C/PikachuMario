using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_movement : MonoBehaviour {

	public float speed;
	public float direction;

	Rigidbody2D cloud;

	// Use this for initialization
	void Awake () {
		cloud = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		cloud.velocity = new Vector2 (speed* direction, 0f);
	}
}
