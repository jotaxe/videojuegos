using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cratesScript : MonoBehaviour {


	public GameObject singleCrate;
	public GameObject platform;
	public Transform refPoint;
	private float crateWidth;
	private float platformWidth;
	void Start () {
		crateWidth = singleCrate.GetComponent<BoxCollider2D>().size.x;
		platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < refPoint.position.x){
			transform.position = new Vector3(transform.position.x + platformWidth +  2 * crateWidth, transform.position.y, transform.position.z);
		}
	}
}