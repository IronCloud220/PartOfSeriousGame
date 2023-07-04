using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWater : MonoBehaviour
{
    public GameObject water;
    public float waterMaxX;
    public float waterMaxY;
    public float waterMinX;
    public float waterMinY;
    public float timeOfWater;
    private float waterSpawnTime;


    // Update is called once per frame
    void Update()
    {
        float layerDelay = 0f;
        if (Contact1.distanceTravelled < BackgroundChange.crust)//add
        {
            layerDelay = 10f;
        }
        else if (Contact1.distanceTravelled < BackgroundChange.mantle)
        {
            layerDelay = 7f;
        }
        else if (Contact1.distanceTravelled < BackgroundChange.outercore)
        {
            layerDelay = 3f;
        }
        else
        {
            layerDelay = 0f;
        }

        if (Time.time > waterSpawnTime)
        {
            Spawn();
            waterSpawnTime = Time.time + timeOfWater + layerDelay;

        }

    }

    void Spawn()
    {
        float randomX = Random.Range(waterMinX, waterMaxX);
        float randomY = Random.Range(waterMinY, waterMaxY);

        Instantiate(water, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
