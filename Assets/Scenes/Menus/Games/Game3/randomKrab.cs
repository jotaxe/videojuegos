using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class randomKrab : MonoBehaviour
{

    public GameObject krabsState;
    public float[] positionX = new float[] { -11.42f, -3.78f, 3.66f, 11.3f };
    public float[] positionY = new float[] { 2.52f, 0.44f, -1.64f, -3.67f };

    private Rigidbody2D rb;
    private Animator anim = null;
    public Vector3 center;
    public AudioClip damageSound;  

    // Game Rules 

    public int hitTimes = 0;
    public int timeToFinish = 10;
    public float elapsedTime = 0f;
    int elapsedTimeInt = 0;              
    bool gameFinished = false;

    // Game Effects 

    public Text scoreText; 
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        source = GetComponent<AudioSource>();
        UpdateScoreText();
    }

    void Update()
    { 
        if (gameFinished == false) 
        {
            elapsedTime += Time.deltaTime;
            Debug.Log(elapsedTime);

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
                    source.PlayOneShot(damageSound, 1f);
                    anim.Play("Krab");
                    elapsedTimeInt = (int)elapsedTime;     
                    if (elapsedTimeInt == timeToFinish)
                    { 
                        colaider = null;
                        gameFinished = true;

                        //Invoke("waitForSec", 2);
                        StartCoroutine(delay());
                        //GameObject net = GameObject.Find("Network");
                        //NetworkManager netMan = net.GetComponent<NetworkManager>();
                        //netMan.ServerChangeScene("mapsChoiceMenu");
                    }
                    UpdateScoreText();
                    transform.position = new Vector3(positionX[auxIndexX], positionY[auxIndexY], transform.position.z);

                }
            }
        }


    }

    //void waitForSec(){

    //    Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    //}
    IEnumerator delay()
    {
        yield return new WaitForSeconds(2);
    }
    void UpdateScoreText()
    {
        scoreText.text = hitTimes + " Hits " + "in " + elapsedTime + " seconds";

    }


}
