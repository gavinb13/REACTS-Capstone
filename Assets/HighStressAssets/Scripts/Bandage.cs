using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : MonoBehaviour
{

    private Coroutine stopBleedingCoroutine;
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Trigger entered. Colliding with: " + other.name);

        if (other.gameObject.CompareTag("Wound")) // The wound tag is still on the parent empty GameObject
        {
            // Start the delay coroutine
            Debug.Log("Found the wound" + other.name);


            stopBleedingCoroutine = StartCoroutine(StopBleeding(other));

            Debug.Log("Co routine done!");
        }

       /* if (other.gameObject.CompareTag("Wound")) // The wound tag is still on the parent empty GameObject
        {
       


            ParticleSystem bloodParticles = other.transform.Find("Particle System").GetComponent<ParticleSystem>();
            if (bloodParticles != null)
            {
                bloodParticles.Stop(); // Stop the particle system when the bandage touches the wound
                                       // Additional feedback can be added here
            }


        }*/

    }

    private IEnumerator StopBleeding(Collider wound)
    {
        // Wait for 5 seconds

        yield return new WaitForSeconds(5);

        // Access the ParticleSystem component
        //ParticleSystem bloodParticles = wound.transform.Find("Particle System").GetComponent<ParticleSystem>();
        ParticleSystem bloodParticles = wound.GetComponentInChildren<ParticleSystem>(true);

        if (bloodParticles != null)
        {
            bloodParticles.Stop(); // Stop the particle system after 5 seconds
            // Additional feedback can be added here such as sound effects or visual cues
        }
    }
}
