using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadLevelAgain()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
