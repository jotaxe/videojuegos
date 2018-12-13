using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

	public void startToMultiplayer(){
		SceneManager.LoadScene("MultiplayerMenu_Jota", LoadSceneMode.Single);
	}

	public void MultiplayerToGame1(){
		SceneManager.LoadScene("GameOne_Anty", LoadSceneMode.Single);
	}

    public void MultiplayerToGame2()
    {
        SceneManager.LoadScene("GameTwo_Jota", LoadSceneMode.Single);
    }

}
