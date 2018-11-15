using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerGameScript : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public float speed;
    public Transform playerTransform;

	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

		
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.up * 7 * Time.deltaTime;
		}
	}
    public override void OnStartLocalPlayer()
    {
        Camera.main.GetComponent<Follow>().SetTarget(gameObject.transform);
    }
}
