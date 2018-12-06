using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomKrab : MonoBehaviour {

    public GameObject[] krabsState;
    private Rigidbody2D rb;
    private Animator anim = null;

    // Game Rules 

    public int hitTimes = 0; 
    public float timeToFinish = 30f;
    private int currentIndex = 0;
    public float elapsedTime = 0f;
    public float duration = 5f; // repeticiones del gameobject 

    // krab props

    bool isHitted;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {

        elapsedTime += Time.deltaTime;

        // si el tiempo transcurrido es mayor al tiempo de duracion 
        if (elapsedTime >= duration)
        {
            if (elapsedTime <= timeToFinish)
            {
                int auxIndex = Random.Range(0, krabsState.Length);

                Debug.Log(currentIndex);
                Debug.Log(elapsedTime);

                krabsState[currentIndex].SetActive(false);
                currentIndex = auxIndex;
                krabsState[currentIndex].SetActive(true);

                // si se toco el collider 

                if (Input.GetMouseButtonDown(0))
                {
                    foreach (GameObject krab in krabsState)
                    {

                        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        EdgeCollider2D coll = krabsState[currentIndex].GetComponent<EdgeCollider2D>();


                        if (coll.OverlapPoint(wp))
                        {
                            Debug.Log(hitTimes);
                            hitTimes += 1;
                            anim.Play("hitKrab");
                            // anim.SetBool("isCutting", true);
                            anim.SetInteger("hp", hitTimes);
                            if (elapsedTime == timeToFinish)
                            {
                                coll = null;
                            }
                        }

                    }
                }
            } 
            elapsedTime -= duration;
        }
    }


}
