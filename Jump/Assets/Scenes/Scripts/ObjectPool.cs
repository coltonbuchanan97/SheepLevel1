using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

    public GameObject pooledObject;

    public int amount;

    List<GameObject> pool;

    // Use this for initialization
    void Start() {
        pool = new List<GameObject>();

        for (int i = 0; i < amount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject getPooledObject()
    {
        for(int i =0; i < pool.Count; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                return pool[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject);
        obj.SetActive(false);
        pool.Add(obj);
        return obj;
    }

}
