using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCoordinates : MonoBehaviour {
	float x_coordinateC;
	float y_coordinateC; 
	float z_coordinateC;
	public CoordinatesOfHouse CH;

	float house_coordinates_x;
	float house_coordinates_y;
	float house_coordinates_z;
	public float Delta_X;
	float Delta_Z;
	float angle;
	float corrected_angle_xz_plane;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		x_coordinateC = transform.position.x;
		y_coordinateC = transform.position.y;
		z_coordinateC = transform.position.z;

		house_coordinates_x = CH.x_coordinate;
		house_coordinates_y = CH.y_coordinate;
		house_coordinates_z = CH.z_coordinate;

		Delta_X = x_coordinateC - house_coordinates_x;
		Delta_Z = z_coordinateC - house_coordinates_z;

		angle = Mathf.Rad2Deg*Mathf.Atan(Delta_Z/Delta_X);
		corrected_angle_xz_plane = 7-angle;

		//Debug.Log (corrected_angle_xz_plane);
	}
}
