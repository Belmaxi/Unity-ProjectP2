using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float posZ = 20f;
    private float SpawnRangeX = 20f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    private void Update()
    {
            
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, posZ);
        Instantiate(animalPrefabs[animalIndex], SpawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

