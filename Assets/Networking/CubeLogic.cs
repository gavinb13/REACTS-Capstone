using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class CubeLogic : NetworkBehaviour
{
    
    private NetworkManager nm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnNetworkSpawn()
    {
        nm = TrainingLogic.Instance.nm;
        Debug.Log("Cube Shows up");


    }
}
