using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class changeCharacter : MonoBehaviour {

    public Sprite spritek;
    public Sprite spritem;
    public Sprite spriteb;
    public Sprite spriteng;

    public void SelectKgnith(){
        gameObject.GetComponent<Image>().overrideSprite = spritek;
    }

    public void SelectMage(){
        gameObject.GetComponent<Image>().overrideSprite = spritem;
    }

    public void SelectBarbarian(){
        gameObject.GetComponent<Image>().overrideSprite = spriteb;
    }

    public void SelectDude(){
        gameObject.GetComponent<Image>().overrideSprite = spriteng;
    }
}
