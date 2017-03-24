using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject shell;
	int counter=0;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		counter++;

		if(counter %10 ==0){Instantiate (shell);}
	}
}
