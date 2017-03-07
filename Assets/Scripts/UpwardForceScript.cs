using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardForceScript : MonoBehaviour {
	public float thrust;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		rb.AddForce(transform.up * thrust);
	}
}
