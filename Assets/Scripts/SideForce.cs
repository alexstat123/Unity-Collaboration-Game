﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class SideForce : MonoBehaviour { 	public float thrust; 	private Rigidbody rb; 	public bool Sideforce=false; 	public bool forwardforce = false;  	void Start () { 		rb = GetComponent<Rigidbody>(); 	}  	void FixedUpdate() { 		//rb.AddForce(Vector3.forward * thrust * Time.deltaTime); 		//rb.AddForce (thrust * Time.deltaTime,0,0); 		//rb.AddForce(new Vector3(0,thrust * Time.deltaTime,0));  		//rb.AddForce(Vector3. * thrust * Time.deltaTime); 		if(forwardforce==true) 		{ 			rb.AddForce(-1,0, 0, ForceMode.Impulse); 		}  		if(Sideforce==true) 		{ 			rb.AddForce(0,0, 1, ForceMode.Impulse); 		} 	} } 