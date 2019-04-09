using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour {
	public float BoosSpeed;
	public float Speed;
	public float timer = 60f;
	public float cooldown = 60f;

	bool isBoosted = false;
	float boostTime = 0f;
	float boostLimit = 5f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		if(timer >= cooldown && Input.GetMouseButton (0))
		{
			isBoosted = true;
			gameObject.GetComponent<Movement> ().maxSpeed = gameObject.GetComponent<Movement> ().maxSpeed + 0.8f;
		}


		if (isBoosted == true) {
			boostTime += Time.deltaTime;
			if(boostTime >= boostLimit) {
				isBoosted = false;
				gameObject.GetComponent<Movement> ().maxSpeed = gameObject.GetComponent<Movement>().tempSpeed;
				boostTime = 0;
				timer = 0;
			}
		}

		/*if (Input.GetMouseButton (0) && timer < cooldown)
			 boostTime += Time.deltaTime;
			
			 gameObject.GetComponent<Movement> ().maxSpeed = 10;
		}
		if (timer >= 60 ) 
		{
			count = 1;
			timer = 0;
			gameObject.GetComponent<Movement> ().maxSpeed = 1;

		}*/
	}
}
