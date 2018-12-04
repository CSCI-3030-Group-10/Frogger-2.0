using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehchleSpawn : MonoBehaviour {

    public Rigidbody2D spawner;
    public GameObject vehicle;

    public float spawnDelay = 10f;
    float spawnTime = 0f;

    private void Update()
    {
        if(spawnTime <= Time.time)
        {
            Spawn();
            spawnTime = Time.time + spawnDelay;
        }
    }

    void Spawn()
    {
        Instantiate(vehicle);
    }

}
