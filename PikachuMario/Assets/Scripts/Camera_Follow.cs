using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

	public float smooth;
	public GameObject player;
	Vector3 velocity;
	// Update is called once per frame
	void LateUpdate () {
		Vector3 temp = Vector3.SmoothDamp (this.transform.position, player.transform.position,ref velocity, smooth, 2f, 0.5f);
		temp.z = -10f;
		this.transform.position = temp;
	}
}
