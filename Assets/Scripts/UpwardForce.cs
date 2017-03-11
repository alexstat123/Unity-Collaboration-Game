using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardForce : MonoBehaviour {
	public float thrust;

	private Rigidbody rb;
	
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate() {
		rb.AddForce(Vector3.up * thrust * Time.deltaTime);
	}
}
