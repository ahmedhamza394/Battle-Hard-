using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public float chances = 3f;
	public float gracePeriod = 1f;
	public float currPos;
	public float sum;
	public bool canCollide = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	/*	sum = sum + Time.deltaTime;
		if(sum >= gracePeriod)
		{
			canCollide = true;
		}*/
	}
	void OnCollisionEnter2D(Collision2D col){
		/*Debug.Log ("LOL");
		if (canCollide == true) {
			chances = chances - 1;
			canCollide = false;
			sum = 0;
			Debug.Log (chances);
		}*/
		if (col.transform.name [1] == 'q') {
			return;
		}

		if (col.transform.name [0] == 'B') {
			return;
		}
		/*if (col.transform.name [0] == 'H') {
			chances += 1;
			GameObject.Find ("HpUp").GetComponent<HpPowerUp> ().count = 0;
			Destroy (gameObject.transform.name[0] == 'H');
			return;
		}*/
		if(col.transform.name[0] == 'P'){	
			chances = chances - 1;
			if (chances <= 0) {
				Destroy (gameObject);
			}
		}
			
	}
}
