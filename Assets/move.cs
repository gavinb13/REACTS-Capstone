using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5.0f; // Speed of movement in the z-direction
    public float propellerSpeed = 1000.0f; // Speed of propeller rotation
    public float distanceToTravel = 10.0f; // Distance the object should travel before disappearing

    private float distanceTraveled = 0.0f;
    private Transform propellerTransform;
    private Vector3 initialPosition;

    void Start()
    {
        // Find the propeller GameObject
        propellerTransform = transform.Find("proppeler");

        // Store the initial position
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object in the z-direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Update the distance traveled
        distanceTraveled += speed * Time.deltaTime;

        // Rotate the propeller
        if (propellerTransform)
        {
            propellerTransform.Rotate(Vector3.up * propellerSpeed * Time.deltaTime); // Rotate around the y-axis
        }

        // Check if the object should disappear
        if (distanceTraveled >= distanceToTravel)
        {
            // Clone the GameObject
            CloneAndStart();
            Destroy(gameObject); // Destroy the original object
        }
    }

    public void CloneAndStart()
    {
        GameObject clone = Instantiate(gameObject, initialPosition, transform.rotation); // Clone the GameObject at the initial position
        move cloneScript = clone.GetComponent<move>(); // Get the move script from the clone
        if (cloneScript)
        {
            cloneScript.enabled = true; // Enable the move script on the clone
        }
    }
}