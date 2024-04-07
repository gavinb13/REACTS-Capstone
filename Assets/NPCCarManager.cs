using System.Collections;
using UnityEngine;

public class NPCCarManager : MonoBehaviour
{
   
    public GameObject carPrefab; // The car model to spawn
    public Vector3 spawnPosition; // Position to spawn the car at
    public float baseSpeed = 5f; // Base speed of the car
    public float spawnIntervalMin = 1f; // Minimum spawn interval
    public float spawnIntervalMax = 10f; // Maximum spawn interval
   
   

    private void Start()
    {
        // Start spawning cars
        StartCoroutine(SpawnCars());
    }

    private IEnumerator SpawnCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(spawnIntervalMin, spawnIntervalMax));
            SpawnCar();
        }
    }

    private void SpawnCar()
    {
        // Instantiate the car at the specified spawn position
        GameObject car = Instantiate(carPrefab, spawnPosition, Quaternion.identity);
        float speedModifier = Random.Range(0.8f, 1.1f); // Random speed modifier for variability
        car.AddComponent<CarMovement>().speed = baseSpeed * speedModifier; // Set the car's speed
        Destroy(car, 10f); // Destroy the car after 10 seconds
    }
}

public class CarMovement : MonoBehaviour
{
    public float speed = 5f;
    

    private void Update()
    {
        // Move the car straight forward
       
 transform.Translate(Vector3.forward * speed * Time.deltaTime);
       
       
    }
}
