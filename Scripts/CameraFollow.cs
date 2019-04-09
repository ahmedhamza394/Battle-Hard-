using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 aaron = new Vector3 (GameObject.Find ("You").transform.position.x, GameObject.Find ("You").transform.position.y, transform.position.z);
		//float tempZ = transform.position.z;
		//transform.position = GameObject.Find ("Player").transform.position;
		transform.position = aaron;
	}
}
