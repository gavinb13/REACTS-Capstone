using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRigReference : MonoBehaviour
{
    public static VRRigReference Singleton;
    public Transform root;
    public Transform left;
    public Transform right;

    public void Awake() {
        Singleton = this;
    }
}
