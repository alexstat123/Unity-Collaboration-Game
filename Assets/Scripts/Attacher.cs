using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacher : MonoBehaviour {

	void Awake () {
		var house = GameObject.FindWithTag("House");
		var attachTo = house.GetComponent<Rigidbody>();

		var joint = GetComponent<FixedJoint>();
		joint.connectedBody = attachTo;
		
		
	}
	
}
