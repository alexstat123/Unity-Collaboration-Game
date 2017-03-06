using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatntiateObject : MonoBehaviour {

	public GameObject ballon;
	int counter = 0;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		counter++;
		if(counter == 100){

			Instantiate (ballon,new Vector2(0,0),transform.rotation); // here was transform.posittion

		}
	}
}
