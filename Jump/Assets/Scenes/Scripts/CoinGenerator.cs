using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public ObjectPool coinPool;
    public ObjectPool coinPool2;

    public float distance;

    public void SpawnCoins(Vector3 spawnPoint)
    {
        /*
        GameObject coin1 = coinPool.getPooledObject();
        coin1.transform.position = spawnPoint;
        coin1.SetActive(true);
        */

        if (Random.Range(0f, 100f) < 60)
        {
            GameObject coin2 = coinPool.getPooledObject();
            coin2.transform.position = new Vector3(spawnPoint.x - distance, spawnPoint.y, spawnPoint.z);
            coin2.SetActive(true);
        }
        else
        {
            GameObject coin2 = coinPool2.getPooledObject();
            coin2.transform.position = new Vector3(spawnPoint.x - distance, spawnPoint.y, spawnPoint.z);
            coin2.SetActive(true);
        }

        /*
        GameObject coin3 = coinPool.getPooledObject();
        coin3.transform.position = new Vector3(spawnPoint.x + distance, spawnPoint.y, spawnPoint.z);
        coin3.SetActive(true);
        */


    }

}