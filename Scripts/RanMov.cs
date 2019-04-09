using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanMov : MonoBehaviour
{

	float maxSpeed = 10f;
	float timer = 0f;
	Vector3 randomspot;
	Vector3 direction;
	float x = 0.2f;
	void Start () 

	{
		randomspot.x = transform.position.x;
		randomspot.y = transform.position.y;
		randomspot.z = transform.position.z;
	//	randomspot = new Vector3 (Random.Range (-15, 15), Random.Range (-15, 15), 0);
	//	direction = randomspot - transform.position;
	//	transform.position = transform.position + (direction.normalized * maxSpeed) * Time.deltaTime;

	}

	// Update is called once per frame
	void Update () 
	{
		timer = timer + Time.deltaTime;
		direction.z = 0;
		//if (V3Equals(transform.position, randomspot)) 
		//if(timer >= 2)
		if((transform.position - randomspot).sqrMagnitude <= x * x)
		{
			randomspot = new Vector3 (Random.Range (-15, 15), Random.Range (-15, 15), 0);
			//maxSpeed = maxSpeed * Time.deltaTime;

			//transform.position = Vector3.MoveTowards (transform.position, randomspot, maxSpeed);
			//Debug.Log ("x: " + randomspot.x);
			//Debug.Log ("y: " + randomspot.y);
			timer = 0;

		}
		direction = randomspot - transform.position;
		transform.position = transform.position + (direction.normalized * maxSpeed) * Time.deltaTime;

	}
	/*public bool V3Equals(Vector3 a, Vector3 b)
	{
		return Vector3.SqrMagnitude (a - b) < 0.0001;
	}*/


		
}


