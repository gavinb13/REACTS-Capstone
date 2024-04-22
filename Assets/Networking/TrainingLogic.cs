using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;

public class TrainingLogic : NetworkBehaviour
{

    public static TrainingLogic Instance { get; private set; }
    
    public NetworkManager nm;
    public UnityTransport transport;

    public NetworkObject player;


    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;
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
        transport.SetConnectionData("127.0.0.1", 54506, "0.0.0.0");
    }

    public void Host()
    {
        if (nm.StartHost())
        {
            //developmentUi.SetActive(false);;
            Debug.Log("Host  Started");
        }
        else Debug.LogError("Failed to start hosting");
    }

    public void Player()
    {
        if (nm.StartClient())
        {
            //developmentUi.SetActive(false);
            Debug.Log("Client  Started");
        }
        else Debug.LogError("Failed to start Client");
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
                    var newPlayer = Instantiate(player);
                    newPlayer.Spawn();
                    Debug.Log("CLIENT JOINED");

                }
                else
                {
                    Debug.Log("HOST JOINED");
                }
                break;
            case ConnectionEvent.ClientDisconnected:
                
                break;
        }
    }


}
