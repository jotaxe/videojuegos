using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orcScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(gameObject.tag);
	}
	

	public float speed = 1.5f;
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
