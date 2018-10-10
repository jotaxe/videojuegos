using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class changeCharacter : MonoBehaviour {

    public Sprite spritek;
    public Sprite spritem;
    public Sprite spriteb;
    public Sprite spriteng;

    public void SelectKnight(){
        gameObject.GetComponent<Image>().overrideSprite = spritek;
        gameObject.GetComponent<Image>().color = new Vector4(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, 255);
    }

    public void KnightText(){
        gameObject.GetComponent<Text>().text = "Honorable knight, with heavy armor, heavy shield, heavy sword and of course, heavy balls";
 
    }

    public void SelectMage(){
        gameObject.GetComponent<Image>().overrideSprite = spritem;
        gameObject.GetComponent<Image>().color = new Vector4(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, 255);
    }

    public void MegeText(){
        gameObject.GetComponent<Text>().text = "Not so brilliant mage, his stronger spells is '90% Levitation' wich makes him almost levitate";
    }

    public void SelectBarbarian(){
        gameObject.GetComponent<Image>().overrideSprite = spriteb;
        gameObject.GetComponent<Image>().color = new Vector4(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, 255);
    }

    public void BarbarianText(){
        gameObject.GetComponent<Text>().text = "Viking warrior with inmesurable strenght. Likes kitties.";
    }

    public void SelectDude(){
        gameObject.GetComponent<Image>().overrideSprite = spriteng;
        gameObject.GetComponent<Image>().color = new Vector4(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, 255);
    }

    public void DudeText(){
        gameObject.GetComponent<Text>().text = "His name is Jimmy.";
    }
}
