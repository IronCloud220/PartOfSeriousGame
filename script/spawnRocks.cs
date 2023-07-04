using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRocks : MonoBehaviour
{
    public GameObject rock;
    public float rockMaxX;
    public float rockMaxY;
    public float rockMinX;
    public float rockMinY;
    public float timeOfRock;
    private float rockSpawnTime;


    // Update is called once per frame
    void Update()
    {
        float layerDelay = 0f;
        if (Contact1.distanceTravelled < BackgroundChange.crust)//add
        {
            layerDelay = 5f;
        }
        else if (Contact1.distanceTravelled < BackgroundChange.mantle)
        {
            layerDelay = 4f;
        }
        else if (Contact1.distanceTravelled < BackgroundChange.outercore)
        {
            layerDelay = 3f;
        }
        else
        {
            layerDelay = 0f;
        }

        if (Time.time > rockSpawnTime)
        {
            Spawn();
            rockSpawnTime = Time.time + timeOfRock + layerDelay;
            
        }
        
    }

    void Spawn()
    {
        float randomX = Random.Range(rockMinX, rockMaxX); 
        float randomY = Random.Range(rockMinY, rockMaxY);

        Instantiate(rock, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
