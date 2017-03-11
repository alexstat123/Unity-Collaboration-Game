using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public float offsetX;
	public float offsetY;

	//public float transitionSpeed;
	
	public GameObject target;
	
	
	// Update is called once per frame
	void FixedUpdate () {

		var x = target.transform.position.x + offsetX;
		var y = target.transform.position.y + offsetY;
		transform.position = new Vector3(x, y, transform.position.z);
	
		//float step = transitionSpeed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards(transform.position, new Vector3(x, y, transform.position.z), step);
	}
}
