﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerGameScript : NetworkBehaviour {

    public float speed;
    public Transform playerTransform;
    public ScoreTracker tracker;
    [SyncVar]
    public int score = 0;


	// Use this for initialization
    void Start () {
        Camera Cam = Camera.main;
        tracker = Cam.GetComponent<ScoreTracker>();
	}
	
	// Update is called once per frame
	
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime;

            if(!isServer){
                return;
            }

            score += 1;
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
        gameObject.tag = "Player";
        Debug.Log(gameObject.tag);
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag == "Orc"){
            tracker.gameEnded = true;
        }
	}
}
