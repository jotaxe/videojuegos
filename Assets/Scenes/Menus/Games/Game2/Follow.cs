using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform playerTransform;
	Vector3 tempVec3 = new Vector3();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
        if (playerTransform != null)
        {
            tempVec3.x = playerTransform.position.x;
            tempVec3.y = this.transform.position.y;
            tempVec3.z = this.transform.position.z;
            this.transform.position = tempVec3;
        }
	}

    public void SetTarget(Transform target)
    {
        playerTransform = target;
    }

}
