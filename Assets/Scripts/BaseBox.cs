using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBox : MonoBehaviour {

	public GameObject balloonPrefab;
	public Transform spawnPoint;

	void OnMouseDown(){
		Instantiate (balloonPrefab, spawnPoint.position, spawnPoint.rotation);
	}
}
