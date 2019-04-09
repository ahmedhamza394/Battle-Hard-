using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour {

	public GameObject border;
	// Use this for initialization
	void Start () {

		//Vector3 pos = new Vector3 (-15, 15, 0);
		//Instantiate (border, pos , transform.rotation);
	
		for (int i = -15; i <= 15; i++) {
			Vector3 pos1 = new Vector3 (i, 15, 0);
			Instantiate (border, pos1 , transform.rotation);
		}
		for (int i = -15; i <= 15; i++) {
			Vector3 pos1 = new Vector3 (15, -i, 0);
			Instantiate (border, pos1 , transform.rotation);
		}	

		for (int i = -15; i <= 15; i++) {
			Vector3 pos1 = new Vector3 (i, -15, 0);
			Instantiate (border, pos1 , transform.rotation);
		}
		for (int i = -15; i <= 15; i++) {
			Vector3 pos1 = new Vector3 (-15, i, 0);
			Instantiate (border, pos1 , transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {

		//for(int i=-100; i < 101; i++)
		//{
			
			
		//}
	}
}
