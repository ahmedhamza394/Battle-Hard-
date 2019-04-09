using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float maxSpeed;
	public float tempSpeed;
	public float timer = 0f;
	public float boostTimer = 0f;
	public float speedTime = 10f;
	public bool hasCollided = false;
	// Use this for initialization
	void Start () 
	{
		maxSpeed = 5f;
		tempSpeed = 5f;
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer > speedTime) {
			maxSpeed += 1;
			tempSpeed += 1;
			timer = 0;
		}

		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePosition.z = 0;

		Vector3 direction = mousePosition - transform.position;

		transform.position = transform.position + (direction.normalized * maxSpeed)*Time.deltaTime;

		if (hasCollided == true) 
		{
			boostTimer += Time.deltaTime;
			if (boostTimer >= 5) {
				maxSpeed = tempSpeed;
				hasCollided = false;
			}
		}

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.name [2] == 'o') {
			hasCollided = true;
		}
	}
}
