using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartToMultiplayer : MonoBehaviour {

    public void LoadMultiplayerScene() {
        SceneManager.LoadScene("MultiplayerMenu_Jota", LoadSceneMode.Single);
    }	
}
