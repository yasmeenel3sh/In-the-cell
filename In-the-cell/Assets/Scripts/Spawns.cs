using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour {
    public GameObject[] spawns;
    float speed;
    float spawnTime ;
    float spawnTimer;
    float speedTime ;
    float speedTimer;
	// Use this for initialization
	void Start () {
        spawnTime = 3;
        spawnTimer = 0;
        speedTime = 1;
        speedTimer = 0;
        speed = 100f;
        
    }
	
	// Update is called once per frame
	void Update () {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnTime)
        {
            Spawn();
            spawnTimer = 0;
        }

	}
    void Spawn()
    {
        int toBeSpawnedIndex = Random.Range(0, spawns.Length);
        float randomZ = Random.Range(-8f, 8f);
        float step = speed * Time.deltaTime;
        Debug.Log(toBeSpawnedIndex);
        GameObject toBeSpawned = Instantiate(spawns[toBeSpawnedIndex], new Vector3(-10, 0f, randomZ), Quaternion.identity);
   
    }
}
