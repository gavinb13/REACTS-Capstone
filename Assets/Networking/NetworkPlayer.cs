using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkPlayer : NetworkBehaviour
{

    public Transform root;
    public Transform left;
    public Transform right;

    public Renderer[] meshToDisable;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        if(IsOwner) 
        {
            foreach(var item in meshToDisable)
            {
                item.enabled = false;
            }
        }
    }

    void Update() {
        if(IsOwner) {
            root.position = VRRigReference.Singleton.root.position; 
            root.rotation = VRRigReference.Singleton.root.rotation;

            left.position = VRRigReference.Singleton.left.position; 
            left.rotation = VRRigReference.Singleton.left.rotation;

            right.position = VRRigReference.Singleton.right.position; 
            right.rotation = VRRigReference.Singleton.right.rotation;
        }
    }
}
