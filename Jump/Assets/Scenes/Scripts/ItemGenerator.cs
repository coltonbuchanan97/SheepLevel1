using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    public ObjectPool fence;
    public ObjectPool wolf;
    public ObjectPool barn;

    public float distance;

    public void SpawnItems(Vector3 spawnPoint)
    {

        if (Random.Range(0f, 100f) < 60)
        {
            GameObject fenceObj = fence.getPooledObject();
            fenceObj.transform.position = new Vector3(spawnPoint.x - distance, spawnPoint.y, spawnPoint.z);
            fenceObj.SetActive(true);
        }
        if (Random.Range(0f, 100) > 61)
        {
            GameObject wolfObj = wolf.getPooledObject();
            wolfObj.transform.position = new Vector3(spawnPoint.x - distance, spawnPoint.y, spawnPoint.z);
            wolfObj.SetActive(true);
        }
        else
        {
            GameObject barnObj = barn.getPooledObject();
            barnObj.transform.position = new Vector3(spawnPoint.x - distance, spawnPoint.y, spawnPoint.z);
            barnObj.SetActive(true);
        }
        

    }
}
