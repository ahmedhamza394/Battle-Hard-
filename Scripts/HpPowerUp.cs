using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPowerUp : MonoBehaviour {

	public GameObject [] powerUps;
	public float timer;
	public float Spawner = 30f;
	public float count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		int x = Random.Range (0, 2);
		if (timer >= Spawner && count == 0) {
			Vector3 enemyPos = - GameObject.Find ("You").transform.position;
			Instantiate (powerUps[x], enemyPos, transform.rotation);
			//count += 1;
			timer = 0;
		
		}

	}

}

