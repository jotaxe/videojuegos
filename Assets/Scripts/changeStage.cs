using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class changeStage : MonoBehaviour {

public Sprite highlightBack;
	
	// Update is called once per frame
	public void highlightback () {
		gameObject.GetComponent<Image>().overrideSprite = highlightBack;

	}
}
