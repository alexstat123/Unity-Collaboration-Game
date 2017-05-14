using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour {

	//public GameObject shell;
	//public GameObject Bullet_Emitter;
	public Rigidbody Bullet;
	public Transform Barrel_End;
	public float Force = 10000;
	int counter=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		counter++;

		if(counter %10 ==0){
			Rigidbody Temporary_Bullet_Handler;
			

			Temporary_Bullet_Handler=Instantiate(Bullet,Barrel_End.position,Barrel_End.rotation) as Rigidbody;
			Temporary_Bullet_Handler.AddForce (Barrel_End.forward*Force);
			Temporary_Bullet_Handler.transform.Rotate (Vector3.left * -90);
			Destroy (Temporary_Bullet_Handler, 10.0f);
		}
	}
}
