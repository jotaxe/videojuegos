using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorScript : MonoBehaviour {


	public GameObject platform;

    public Transform refPoint;
	
    private float platformWidth;


	void Start () {
		platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < refPoint.position.x){
			transform.position = new Vector3(transform.position.x + platformWidth, transform.position.y, transform.position.z);
		}
	}
}
