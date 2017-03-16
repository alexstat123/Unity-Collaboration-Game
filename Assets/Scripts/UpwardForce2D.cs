using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardForce2D : MonoBehaviour {
	public float thrust;
	public Rigidbody2D rb;
	public int startForceTime=0;

	int timer =0;

	void Start() 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() 
	{

		if(timer >startForceTime)
		{

			rb.AddForce(transform.up * thrust);
		}

	}

	void Update(){

		timer++;
	}

	void OnMouseDown()
	{
		thrust = 0;
	}
}