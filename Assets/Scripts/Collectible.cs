using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

	public float distanceToPickup = 70f;
	public int balloonCount = 10;
	
	private BaseBox house;
	private Renderer rend;
	// Use this for initialization
	void Start () {
		house = GameObject.FindWithTag("House").GetComponent<BaseBox>();
		rend = GetComponent<Renderer>();
	}

	void OnMouseDown() {
		if(CheckDistance()) {
			house.availableBalloons += balloonCount;
			Object.Destroy (this.gameObject);
		}
	}

	bool CheckDistance() {
		float distance = Vector3.Distance(house.transform.position, transform.position);

		if(distance < distanceToPickup)
			return true;
		else
			return false;
		
		//Debug.Log(Vector3.Distance(house.transform.position, transform.position));
	}

	void Update() {

		if(CheckDistance()) {
			rend.material.SetColor("_Color", Color.cyan);
		}
		else {
			rend.material.SetColor("_Color", Color.red);
		}

	}
	
}
