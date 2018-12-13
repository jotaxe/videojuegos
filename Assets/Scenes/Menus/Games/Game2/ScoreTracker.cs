using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {
    
    public playerGameScript gameScript;
    public Text score;
    public bool gameEnded = false;
	// Use this for initialization
	void Start () {
        GameObject Player = GameObject.FindWithTag("Player");
        gameScript = Player.GetComponent<playerGameScript>();
	}
	
	// Update is called once per frame
    void Update () {
        score.text = gameScript.score.ToString();
        if(gameEnded){
            Time.timeScale = 0;
        }
	}
}
