using UnityEngine;

public class VehchleSpawn : MonoBehaviour {

    //The game object that gets spawned.
    public GameObject vehicle;
    //The rotation and change in possition of a spawn point.
    public Transform[] spawnPoints;

    //spawnTime is a counter for the spawning of a vehicle.
    float spawnTime = 3f;
    //spawnIncrement is the increment that spawnTime gets reduced.
    public float spawnIncrement = 0.07f;
    
    //Update runs every second.
    private void Update()
    {
        if(spawnTime <= 0)
        {
            Spawn();
            spawnTime = 3f;
        }
        else
        {
            spawnTime = spawnTime - spawnIncrement;
        }
    }

    //Spawns a car at a random index stored in point.
    void Spawn()
    {
        int point = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[point];
        Instantiate(vehicle, spawnPoint.position, spawnPoint.rotation);
    }
}
