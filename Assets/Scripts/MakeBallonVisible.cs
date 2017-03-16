using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBallonVisible : MonoBehaviour {

	public GameObject ballon1;
	public UpwardForce2D script;
	public UpwardForce2D script2;
	public UpwardForce2D script3;
	public UpwardForce2D script4;
	int clicknumber=0;
	public int ForceOnBallons = 300;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){

		clicknumber++;

		if(clicknumber==1){

			script.thrust=ForceOnBallons;
		}

		if(clicknumber==2){

			script2.thrust=ForceOnBallons;
		}

		if(clicknumber==3){

			script3.thrust=300;
		}

		if(clicknumber==4){

			script4.thrust=300;
		}
	}
}
