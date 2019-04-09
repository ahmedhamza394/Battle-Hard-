using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour {
	public float maxSpeed;
	public float timer;
	public float speedTime = 10f;
	// Use this for initialization
	void Start () {

		maxSpeed = GameObject.Find ("Player").GetComponent<Movement> ().tempSpeed - 1;
	
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer > speedTime) {
			maxSpeed += 1;
			timer = 0;
		}
		Vector3 targetPostion = GameObject.Find ("You").transform.position;
		targetPostion.z = 0;
		Vector3 direction = targetPostion - transform.position;
		direction.z = 0;

		transform.position = transform.position + (direction.normalized * maxSpeed) * Time.deltaTime;
	}
}
