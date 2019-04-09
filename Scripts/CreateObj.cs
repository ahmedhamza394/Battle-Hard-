using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour {


	public GameObject [] enemies;
	float timer;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer = timer + Time.deltaTime;
		if (timer >= 10) 
		{
			int x = Random.Range (0,3);

			Vector3 enemyPos = - GameObject.Find ("You").transform.position;
			Instantiate (enemies[x], enemyPos, transform.rotation);

			timer = 0;
		}

	}
}
