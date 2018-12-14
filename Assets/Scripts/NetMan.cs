using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetMan : MonoBehaviour {

    public NetworkManager networkManager;
    public NetworkLobbyManager lobbyManager;
    public InputField ip;



	private void Awake()
	{
        networkManager = GetComponent<NetworkManager>();
        lobbyManager = GetComponent<NetworkLobbyManager>();


    
	}


    public void StartHost(){
        networkManager.StartHost();
    
    }



    public void StartClient(){
        networkManager.networkAddress = ip.text;
        networkManager.networkPort = 7777;
        networkManager.StartClient();

    }


    public void StartGame2(){
        GameObject net = GameObject.Find("Network");
        networkManager = net.GetComponent<NetworkManager>();
        networkManager.ServerChangeScene("GameTwo_Jota");

    }

    public void StartGame3(){
        GameObject net = GameObject.Find("Network");
        networkManager = net.GetComponent<NetworkManager>();
        networkManager.ServerChangeScene("GameThree_Jota");
    }

    public void StartGame1(){
        GameObject net = GameObject.Find("Network");
        networkManager = net.GetComponent<NetworkManager>();
        networkManager.ServerChangeScene("GameOne_Anty");

    }

    public void GameOver(){
        GameObject net = GameObject.Find("Network");
        networkManager = net.GetComponent<NetworkManager>();
        networkManager.ServerChangeScene("mapsChoiceMenu");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
