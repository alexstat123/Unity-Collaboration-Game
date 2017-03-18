using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeDestroy : MonoBehaviour {

	public GameObject balloon;
	public FixedJoint rootJoint;
	public int timeToDestroyRope = 2;
	public int timeToRopeDetach = 1;
	float timer;

	// Update is called once per frame
	void Update () {
		DestroyBallon ();
	}

	void DestroyBallon()
	{
		if(balloon==null)
		{
			StartTimerAndDestroy ();
		}
	}



	void StartTimerAndDestroy()
	{
		timer += Time.deltaTime;

		if(timer > timeToDestroyRope) {
			Destroy(this.gameObject.transform.parent.gameObject);
		}
		else if(timer > timeToRopeDetach && rootJoint != null) {
			Destroy(rootJoint);
		}

	}
}

