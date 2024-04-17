using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Wound")) // The wound tag is still on the parent empty GameObject
        {
            Debug.Log("I hit something!" + other.name);
            ParticleSystem bloodParticles = other.transform.Find("Particle System").GetComponent<ParticleSystem>();
            if (bloodParticles != null)
            {
                bloodParticles.Stop(); // Stop the particle system when the bandage touches the wound
                                       // Additional feedback can be added here
            }
        }

    }
}
