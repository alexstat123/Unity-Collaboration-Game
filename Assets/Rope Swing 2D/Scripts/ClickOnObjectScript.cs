using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnObjectScript : MonoBehaviour {

	public GameObject ballon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){

		Instantiate (ballon,new Vector2(-3,0),transform.rotation);
		Debug.Log ("Clicked on Object");
	}
}
