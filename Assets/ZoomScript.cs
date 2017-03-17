using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour {

	public Follow followcamerscript;
	public int initialZoom=25;
	public int MinZoom = 25;
	public int MaxZoom = 50;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		zoomfunction ();
		Debug.Log (initialZoom);
	}



	void zoomfunction()
	{
		followcamerscript.offsetX = initialZoom;

		if (Input.GetKey(KeyCode.RightArrow))
		{
			if(initialZoom <MaxZoom)
			{
				initialZoom++;
			}


		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			if(initialZoom > MinZoom)
			{
				initialZoom--;
			}

		}

	}
}
