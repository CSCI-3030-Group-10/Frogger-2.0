using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpawn : MonoBehaviour {

    //The game object that gets spawned.
    public GameObject powerUp;
    //The rotation and change in possition of a spawn point.
    public Transform[] spawnPoints;

    //spawnTime is a counter for the spawning of a vehicle.
    float spawnTime = 3f;
    //spawnIncrement is the increment that spawnTime gets reduced.
    public float spawnIncrement = 0.07f;

    //Update runs every second.
    private void Update()
    {
        if (spawnTime <= 0)
        {
            Spawn();
            spawnTime = 3f;
        }
        else
        {
            spawnTime = spawnTime - spawnIncrement;
        }
    }

    //Spawns a power up at a random index stored in point.
    void Spawn()
    {
        int point = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[point];
        Instantiate(powerUp, spawnPoint.position, spawnPoint.rotation);
    }
}
