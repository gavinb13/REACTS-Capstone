using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using TMPro;

public class TrainingLogic : NetworkBehaviour
{

    public static TrainingLogic Instance { get; private set; }
    
    public NetworkManager nm;
    public UnityTransport transport;

    public NetworkObject player;
    public TMP_Text cubeText;
    public TMP_Text hudText;

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;
        DontDestroyOnLoad(this);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        nm.OnConnectionEvent += OnConnectionEvent;
        setConnectionAddress();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setConnectionAddress()
    {
        transport.SetConnectionData("192.168.1.19", 7777, "0.0.0.0");
    }

    public void Host()
    {
        if (nm.StartHost())
        {
            //developmentUi.SetActive(false);
            var newPlayer = Instantiate(player);
            newPlayer.Spawn();
            Debug.Log("Host  Started");

            cubeText.text = "Host  Started";
            hudText.text = "Host started...";
        }
        else {
            hudText.text = "There was a problem starting host...";
            Debug.LogError("Failed to start hosting");
        } 
    }

    public void Player()
    {
        if (nm.StartClient())
        {
            //developmentUi.SetActive(false);
            var newPlayer = Instantiate(player);
            newPlayer.Spawn();
            hudText.text = "Client started...";
            cubeText.text = "Client started...";
            Debug.Log("Client  Started");
        }
        else{
            hudText.text = "Failed to start Client";
            Debug.LogError("Failed to start Client");
        }
    }


    void OnConnectionEvent(NetworkManager _, ConnectionEventData data)
    {
/*        var cube = Instantiate(objectPrefab);
        cube.Spawn();
        Debug.Log("Spawned torch for player");*/

        switch (data.EventType)
        {
            case ConnectionEvent.ClientConnected:
                if (nm.IsServer)
                {
                    // var newPlayer = Instantiate(player);
                    // newPlayer.Spawn();
                    hudText.text = "Host has joined...";
                    Debug.Log("HOST JOINED");

                }
                else
                {
                    hudText.text = "Client started...";
                    cubeText.text = "Client started...";
                    Debug.Log("CLIENT JOINED");
                }
                break;
            case ConnectionEvent.ClientDisconnected:
                
                break;
        }
    }


}
