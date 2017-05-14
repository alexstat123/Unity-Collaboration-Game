using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinatesOfHouse : MonoBehaviour {

	public float x_coordinate;
	public float y_coordinate; 
	public float z_coordinate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x_coordinate = transform.position.x;
		y_coordinate = transform.position.y;
		z_coordinate = transform.position.z;
		//Debug.Log (y_coordinate);
	}
}
