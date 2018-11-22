using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomKrab : MonoBehaviour {

    public GameObject krabState;
    private Animator anim = null;

    // Game Rules 

    public int hitTimes = 0;
    public int timeToFinish = 60;
    public int deltaTime = 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            EdgeCollider2D coll = krabState.GetComponent<EdgeCollider2D>();

            if (coll.OverlapPoint(wp))
            {
                Debug.Log(hitTimes);
                hitTimes +=1;
                anim.Play("hitKrab");
                // anim.SetBool("isCutting", true);
                anim.SetInteger("hp", healthPoints);
                if (healthPoints == 0)
                {
                    coll = null;
                }
            }
        }

        //if (transform.position.x < refPoint.position.x)
        //{
        //    transform.position = new Vector3(transform.position.x + platformWidth, transform.position.y, transform.position.z);
        //}

	}
}
