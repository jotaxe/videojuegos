using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.Networking;

public class TreeMovement : MonoBehaviour {
    
    private Rigidbody2D rb;
    private Animator anim = null;

    public GameObject TreeState = null;
    public AudioClip cutSound;  


    // game rules
    int healthPoints = 100;
    //public float timeToFinish = 30f;
    bool gameFinished = false;
    int cutDamage = 5;
    int hits = 0;
    public float elapsedTime = 0f;  // tiempo de duracion partida
    public float duration = 0f;
    public Text scoreText; 

    private AudioSource source;

    // Use this for initialization
    void Start(){
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        UpdateScoreText ();
    }

	// Update is called once per frame
	void Update ()
    {
        if (gameFinished == false) 
        {
            elapsedTime += Time.deltaTime;
            // si se toco el collider 
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                CapsuleCollider2D coll = TreeState.GetComponent<CapsuleCollider2D>();

                if (coll.OverlapPoint(wp))
                {
                    Debug.Log(healthPoints);
                    hits += 1;
                    healthPoints = healthPoints - cutDamage;
                    source.PlayOneShot(cutSound, 1f);
                    anim.Play("cutDown");
                    anim.SetInteger("hp", healthPoints);
                    if (healthPoints == 0)
                    {
                        //StartCoroutine(delay());
                        //Invoke("GoBackToMenu", 4f);
                        coll = null;
                        gameFinished = true;
                        Debug.Log(elapsedTime); 
                        gameObject.GetComponent<NetMan>().GameOver();

                  
                    }
                    UpdateScoreText();
                }
            }
        }
        elapsedTime -= duration;
    }
    void goBackToMenu(){
        gameObject.GetComponent<NetMan>().GameOver();
    }
    //IEnumerator delay()
    //{
    //    yield return new WaitForSeconds(1000);
    //}
    void UpdateScoreText()
    {
        scoreText.text = hits + " Hits " + "in " + elapsedTime + " seconds";

    }

   
}

    

