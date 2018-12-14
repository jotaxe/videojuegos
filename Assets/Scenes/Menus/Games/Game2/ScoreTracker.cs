using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

    public GameObject player;
    public Text score;
    public bool gameEnded = false;
    public playerGameScript gameScript;
	// Use this for initialization
	void Start () {
        GameObject Player = GameObject.FindWithTag("Player");
        gameScript = player.GetComponent<playerGameScript>();
	}
	
	// Update is called once per frame
    void Update () {
        score.text = "Score: " + gameScript.score.ToString();
        if(gameEnded){
            Time.timeScale = 0;
        }
	}
}
