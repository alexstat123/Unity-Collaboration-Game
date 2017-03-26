using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonCounter : MonoBehaviour {

	private BaseBox house;
	private Text text; 
	
	void Start () {
		house = GameObject.FindWithTag("House").GetComponent<BaseBox>();
		text = GetComponentInChildren<Text>();
	}
	
	void Update () {
		text.text = "Balloons left: " + house.availableBalloons;
	}
}
