using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeStage : MonoBehaviour {

public Sprite highlightBack;

public bool cambiado = false;
public Sprite highlightOriginal;
	
	// Update is called once per frame
	public void highlightback () {
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
