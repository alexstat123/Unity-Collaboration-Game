using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBox : MonoBehaviour {

	public GameObject balloonPrefab;
	public Transform spawnPoint;

	public int availableBalloons = 10;

	void OnMouseDown(){

		if(availableBalloons > 0) {
			Instantiate (balloonPrefab, spawnPoint.position, spawnPoint.rotation);
			availableBalloons--;
		}	
	}
}
