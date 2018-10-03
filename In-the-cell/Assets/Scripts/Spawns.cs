using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public GameObject[] spawns;
   public float speed;
    float spawnTime;
    float spawnTimer;
    float speedTime;
    float speedTimer;
    float spawnCounter;
    float speedCounter;
    // Use this for initialization
    void Start()
    {
        spawnTime = 5;
        spawnTimer = 0;
        speedTime = 1;
        speedTimer = 0;
        speed = 1f;
        spawnCounter = 0;
        speedCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnTime)
        {
            Spawn();
            spawnTimer = 0;
        }
        spawnCounter++;
        speedCounter++;
        if (spawnCounter == 100)
        {
            if(spawnTime>0.7f)
            spawnTime -= 0.1f;
            spawnCounter = 0;
        }
        if (speedCounter == 100)
        {
            if (speed < 10)
                speed += 0.2f;
            speedCounter = 0;
        }

    }
    void Spawn()
    {
        int toBeSpawnedIndex = Random.Range(0, spawns.Length);
        float randomX = Random.Range(-2.5f, 2.5f);
        float step = speed * Time.deltaTime;
        Debug.Log(toBeSpawnedIndex);
        GameObject toBeSpawned = Instantiate(spawns[toBeSpawnedIndex], new Vector3(randomX, 5f, 10f), Quaternion.identity);

    }
}
