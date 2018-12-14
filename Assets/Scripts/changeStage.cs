using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;


public class changeStage : NetworkBehaviour {

public Sprite highlightBack;

static bool cambiado = false;
public Sprite highlightOriginal;
	
	// Update is called once per frame
	public void highlightback (GameObject stage) {

		if(!isServer){
			Debug.Log("No soy server po");
			return;
		}
		if(stage.name == "Game1"){
			SceneManager.LoadScene("GameOne_Anty", LoadSceneMode.Single);
		}
		else if (stage.name == "Game2"){
			SceneManager.LoadScene("GameTwo_Jota", LoadSceneMode.Single);
		}
		else if (stage.name == "Game3"){
			SceneManager.LoadScene("GameTwo_Jota", LoadSceneMode.Single);
		}


		if (cambiado == false)
		{
			
			gameObject.GetComponent<Image>().overrideSprite = highlightBack;
			cambiado = true;
		}
		else
		{
			gameObject.GetComponent<Image>().overrideSprite = highlightOriginal;
			cambiado = false; 
		}
		

	}


}
