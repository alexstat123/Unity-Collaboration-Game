using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestroyScript : MonoBehaviour {
	public bool click = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){

		Object.Destroy (this.gameObject);
		click = true;
		//Destroy(lineRenderer.gameObject, 5);
	}
}
