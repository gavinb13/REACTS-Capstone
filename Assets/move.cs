using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5.0f; // Speed of movement in the z-direction

    private float elapsedTime = 0.0f;
    private bool shouldDisappear = false;

    // Update is called once per frame
    void Update()
    {
        // Move the object in the z-direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Check if the object should disappear
        if (shouldDisappear)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= 3.0f)
            {
                Destroy(gameObject); // Destroy the object after 5 seconds
            }
        }
    }

    public void StartDisappearing()
    {
        shouldDisappear = true;
    }
}