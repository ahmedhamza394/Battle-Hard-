using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextT : MonoBehaviour {
	public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
		GetComponent<GUIText> ().text = "Timer:" + timer;
	}
}
