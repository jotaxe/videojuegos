using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {
    
    private Rigidbody2D rb;
    private Animator anim = null;

    public GameObject TreeState = null;
    bool isCuttingDown, isChopedDown;

    int healthPoints = 100;
    int cutDamage = 50;



	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //  SetAnimationState();

        bool talando = false;
        bool talado = false;

        // si se toco el collider 
        if(Input.GetMouseButtonDown(0)){
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            CapsuleCollider2D coll = TreeState.GetComponent<CapsuleCollider2D>();

            if(coll.OverlapPoint(wp)){
                talando = true;
                healthPoints = healthPoints - cutDamage; 
            }

            if (healthPoints == 0){
                talado = true;
                anim.SetBool("isChoppedDown", talado);

            }
        }


        anim.SetBool("isCuttingDown", talando);
        
       
	}
 
 
}
