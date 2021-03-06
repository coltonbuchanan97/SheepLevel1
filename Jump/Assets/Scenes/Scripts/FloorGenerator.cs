﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour {

    public GameObject floor;
    public Transform spawnPoint;
    private float distance;

    private float floorWidth;
    public float distanceMax;
    public float distanceMin;

    public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;

    public ObjectPool[] theObjectPool;

    private CoinGenerator theCoinGenerator;
    public float maxCoinage;

    private ItemGenerator theItemGenerator;
    public float maxItems;

    private float randomPlacement;

    private Vector3 temp;

	// Use this for initialization
	void Start () {
        //floorWidth = floor.GetComponent<BoxCollider2D>().size.x;

        platformWidths = new float[theObjectPool.Length];

        for (int i = 0; i < theObjectPool.Length; i++)
        {
            platformWidths[i] = theObjectPool[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }

        theCoinGenerator = FindObjectOfType<CoinGenerator>();
        theItemGenerator = FindObjectOfType<ItemGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < spawnPoint.position.x)
        {
            distance = Random.Range(distanceMin, distanceMax);

            platformSelector = Random.Range(0, theObjectPool.Length);

            randomPlacement = Random.Range(0f, 2f);

            temp = new Vector3(transform.position.x + platformWidths[platformSelector] + distance, transform.position.y, transform.position.z);

            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + distance, transform.position.y + randomPlacement, transform.position.z);

            //Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation);


            GameObject newPlatform =  theObjectPool[platformSelector].getPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);
   

            if (Random.Range(0f, 100f) < maxCoinage)
            {
                theCoinGenerator.SpawnCoins(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));
            }

            if (Random.Range(0f, 100f) < maxItems)
            {
                theItemGenerator.SpawnItems(new Vector3(transform.position.x, transform.position.y + 0.4f, transform.position.z));
            }

            transform.position = temp;
        }
		
	}
}
