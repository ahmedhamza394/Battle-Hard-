using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour {

	// Use this for initialization
	public float spawnTime = 3f;
	public float timer;
	public GameObject box;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer = timer + Time.deltaTime;
		if (timer >= spawnTime) {
			//int x = Random.Range (0,2);
			Vector3 pos = new Vector3 (Random.Range (-13, 13), Random.Range (-13, 13), 0);
			Instantiate (box, pos, transform.rotation);
			timer = 0;
		}
	}
}
