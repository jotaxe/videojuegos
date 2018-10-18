using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour {
    
    private Rigidbody2D rb;
    private Animator anim = null;

    public GameObject TreeState = null;
    bool isCuttingDown, isChopedDown;

    int healthPoints = 100;
    int cutDamage = 25;



	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //  SetAnimationState();

        // si se toco el collider 
        if(Input.GetMouseButtonDown(0)){
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            CapsuleCollider2D coll = TreeState.GetComponent<CapsuleCollider2D>();

            if(coll.OverlapPoint(wp)){
                Debug.Log(healthPoints);
                healthPoints = healthPoints - cutDamage;
                anim.Play("cutDown");
                // anim.SetBool("isCutting", true);
                anim.SetInteger("hp", healthPoints);
                if(healthPoints == 0){
                    coll = null;
                }
            }
        }
       
	}
}
