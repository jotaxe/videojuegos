using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomKrab : MonoBehaviour
{

    public GameObject krabsState;
    public float[] positionX = new float[] { -11.42f, -3.78f, 3.66f, 11.3f };
    public float[] positionY = new float[] { 2.52f, 0.44f, -1.64f, -3.67f };

    private Rigidbody2D rb;
    private Animator anim = null;
    public Vector3 center;

    // Game Rules 

    public int hitTimes = 0;
    public float timeToFinish = 30f;
    public float elapsedTime = 0f;
    bool gameEnded = false;

    // Use this for initialization


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        elapsedTime += Time.deltaTime;
        Debug.Log(elapsedTime);

        if (elapsedTime <= timeToFinish)
        {
            if (Input.GetMouseButtonDown(0))
            {

                Debug.Log("clickeando");
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                CapsuleCollider2D colaider = krabsState.GetComponent<CapsuleCollider2D>();

                int auxIndexX = Random.Range(0, 4);
                int auxIndexY = Random.Range(0, 4);

                if (colaider.OverlapPoint(wp))
                {
                    anim.Play("hitKrab");
                    Debug.Log(elapsedTime);

                    hitTimes += 1;

                    Debug.Log(hitTimes);
                    anim.Play("Krab");
                    // anim.SetBool("isCutting", true); 
                    if (elapsedTime == timeToFinish)
                    {
                        colaider = null;
                        gameEnded = true;
                    }

                    transform.position = new Vector3(positionX[auxIndexX], positionY[auxIndexY], transform.position.z);

                }
            }
        }


    }

}
