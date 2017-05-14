using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCannon : MonoBehaviour {
	
	public CannonCoordinates CanCor;
	float deltax;
	public bool Rotate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		deltax = CanCor.Delta_X;

		if (Rotate == true) 
		{
			if(deltax< -500){
				RotateTuret ();
			}

		}
			
	}

	void RotateTuret(){

		transform.Rotate(new Vector3(0,-2f,0));
	}
}
