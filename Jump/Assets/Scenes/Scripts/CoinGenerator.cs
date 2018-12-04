using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public ObjectPool coinPool;

    public float distance;

    public void SpawnCoins(Vector3 spawnPoint)
    {
        GameObject coin1 = coinPool.getPooledObject();
        coin1.transform.position = spawnPoint;
        coin1.SetActive(true);

        GameObject coin2 = coinPool.getPooledObject();
        coin2.transform.position = new Vector3(spawnPoint.x - distance, spawnPoint.y, spawnPoint.z);
        coin2.SetActive(true);

        GameObject coin3 = coinPool.getPooledObject();
        coin3.transform.position = new Vector3(spawnPoint.x + distance, spawnPoint.y, spawnPoint.z);
        coin3.SetActive(true);


    }

}