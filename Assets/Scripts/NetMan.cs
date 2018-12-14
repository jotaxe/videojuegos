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
        if(lobbyManager){
            Debug.Log(lobbyManager);  
        }else{
            Debug.Log("no Existe");
        }

    
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
        Debug.Log(lobbyManager.onlineScene);
    }

    public void StartGame3(){
        Debug.Log(lobbyManager.onlineScene);
    }

    public void StartGame1(){
        Debug.Log(lobbyManager.onlineScene);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
