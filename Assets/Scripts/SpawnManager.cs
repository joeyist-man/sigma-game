using System;
using UnityEngine;
using UnityEngine.LightTransport;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Array of GameObjects
    private float spawnRangeX = 20; // Range of the spawn
    private float spawnPosZ = 20; // Position of the spawn
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = UnityEngine.Random.Range(0, 3); // Index of the animalPrefabs array
            Instantiate(animalPrefabs[animalIndex], new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
