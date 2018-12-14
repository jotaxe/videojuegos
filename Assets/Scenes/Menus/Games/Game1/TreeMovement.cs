using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour {
    
    private Rigidbody2D rb;
    private Animator anim = null;

    public GameObject TreeState = null;
    public AudioClip cutSound; 


    // game rules
    int healthPoints = 100;
    public float timeToFinish = 30f;
    int cutDamage = 5;
    public float elapsedTime = 0f;  // tiempo de duracion partida
    public float duration = 0f;
    private AudioSource source;  
 
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        //  SetAnimationState();
        elapsedTime += Time.deltaTime;

        if (elapsedTime <= timeToFinish)
        {
            // si se toco el collider 
            if(Input.GetMouseButtonDown(0)){
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                CapsuleCollider2D coll = TreeState.GetComponent<CapsuleCollider2D>();

                if(coll.OverlapPoint(wp)){
                    Debug.Log(healthPoints);
                    healthPoints = healthPoints - cutDamage;
                    source.PlayOneShot(cutSound, 1f);
                    anim.Play("cutDown"); 
                    anim.SetInteger("hp", healthPoints);
                    if(healthPoints == 0){
                        coll = null;
                        Debug.Log(elapsedTime);
                    }
                }
            } 
        }

        elapsedTime -= duration;
       
	}
}
