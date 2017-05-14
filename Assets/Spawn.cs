using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject shell;
	//public GameObject BarellShell;
	public GameObject BarellShell;

	int counter=0;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		counter++;

		if(counter %10 ==0){
			Instantiate (shell,BarellShell.transform.position,BarellShell.transform.rotation);
			//Instantiate (shell);
		}
	}
}
