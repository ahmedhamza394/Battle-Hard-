using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuke : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("I am In here");
		if(col.transform.name[0] == 'Y')	
		{
			//Debug.Log("I am In here");

			//Destroy (GameObject.FindGameObjectsWithTag ("Clone"));
			//GameObject.Find
			var clones = GameObject.FindGameObjectsWithTag("Player");
			var y = GameObject.FindGameObjectsWithTag ("Square");
			//Destroy (x);
			//Destroy (y);
			//for(var clone in clones)
			//{
			//	De
			//}
			Destroy(gameObject);

		}
		//Destroy(gameObject);

	}
}
