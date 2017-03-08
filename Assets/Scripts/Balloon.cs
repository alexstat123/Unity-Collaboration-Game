using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	void Start () {
	    Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", Random.ColorHSV(0f, 1f, 0.8f, 1f, 0.8f, 1f, 0.6f, 0.8f));	
	}
	
	void OnMouseDown(){
		Object.Destroy (this.gameObject);
	}
}
