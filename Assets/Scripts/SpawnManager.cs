using UnityEngine;
using UnityEngine.LightTransport;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Array of GameObjects
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, 3); // Index of the animalPrefabs array
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
