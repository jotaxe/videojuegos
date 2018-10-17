using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {


	private string character = PlayerData.Character;

	
    public Sprite spritek;
    public Sprite spritem;
    public Sprite spriteb;
    public Sprite spriteng;

	void SelectCharacter(string chara){
		switch (chara)
		{
			case "knight":
				gameObject.GetComponent<SpriteRenderer>().sprite = spritek;
				break;
			case "mage":
				gameObject.GetComponent<SpriteRenderer>().sprite = spritem;
				break;
			case "barbarian":
				gameObject.GetComponent<SpriteRenderer>().sprite = spriteb;
				break;
			case "dude": 
				gameObject.GetComponent<SpriteRenderer>().sprite = spriteng;
				break;
			default:
				gameObject.GetComponent<SpriteRenderer>().sprite = spriteng;
				break;
		}
	}

	void Start () {
		SelectCharacter(character);		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
