using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

	public float smooth, offset;
	public GameObject player;
	Vector3 velocity;
	// Update is called once per frame
	void LateUpdate () {
		Vector3 temp = player.transform.position;
		temp.z = -10f;
		temp.y += offset;
		this.transform.position = temp;
	}
}
