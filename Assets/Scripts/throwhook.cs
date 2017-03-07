using UnityEngine;
using System.Collections;

public class throwhook : MonoBehaviour {


	public GameObject hook;
	public bool ropeActive;
	int counter=0;
	float increasaltitude=0;
	public int RopeLnegthIneger = 10;



	GameObject curHook;

	// Use this for initialization
	void Start () {
	
		//gameObject.tag = "NoTag";
	}
	
	// Update is called once per frame
	void Update () {
	

		counter++;

		if(counter%5==0){
			
			increasaltitude++;

		}

		ropefunction ();
		//Debug.Log (increasaltitude);

		if (counter == (RopeLnegthIneger +2)){gameObject.tag = "Untagged";}

	}

	void ropefunction(){

		if (counter ==RopeLnegthIneger) { // was here Input.GetMouseButtonDown(0)

		

			if (ropeActive == false) {
			Vector2 destiny = Camera.main.ScreenToWorldPoint (new Vector3(420, 250, 0)); // was (Input.mousePosition)   


				curHook = (GameObject)Instantiate (hook, transform.position, Quaternion.identity); //transform.position

				curHook.GetComponent<RopeScript> ().destiny = destiny;


				ropeActive = true;
			} else {

				//delete rope

				Destroy (curHook);


				ropeActive = false;

			}
		}
	}
}
