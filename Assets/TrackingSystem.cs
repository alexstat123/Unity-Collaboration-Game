using UnityEngine;
using System.Collections;

public class TrackingSystem : MonoBehaviour {
	public float speed = 3.0f;
	public GameObject m_target = null;
	public CannonCoordinates CanCord;
	float deltaX;
	Vector3 m_lastKnownPosition = Vector3.zero;
	Quaternion m_lookAtRotation;

	void Start(){
		

	}
	// Update is called once per frame
	void Update () {
		
		deltaX = CanCord.Delta_X;
		Debug.Log (deltaX);
		if(deltaX >-500){

			TrackingFunction ();
		}

	}

	bool SetTarget(GameObject target){
		if(!target){
			return false;
		}

		m_target = target;

		return true;
	}

	void TrackingFunction(){

		if(m_target){
			if(m_lastKnownPosition != m_target.transform.position){
				m_lastKnownPosition = m_target.transform.position;
				m_lookAtRotation = Quaternion.LookRotation(m_lastKnownPosition - transform.position);
			}

			if(transform.rotation != m_lookAtRotation){
				transform.rotation = Quaternion.RotateTowards(transform.rotation, m_lookAtRotation, speed * Time.deltaTime);
			}
		}
	}
}


