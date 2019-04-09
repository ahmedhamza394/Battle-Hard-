using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		//Debug.Log("I am In here");
		if(col.transform.name[0] == 'Y')	
		{
			//Debug.Log("I am In here");

			GameObject.Find("You").GetComponent<Movement>().maxSpeed *= 1.5f ;
			//GameObject.Find
			Destroy(gameObject);

		}
		//Destroy(gameObject);

	}

}
