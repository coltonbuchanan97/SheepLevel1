using System.Collections;
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


	// Use this for initialization
	void Start () {
        //floorWidth = floor.GetComponent<BoxCollider2D>().size.x;

        platformWidths = new float[theObjectPool.Length];

        for (int i = 0; i < theObjectPool.Length; i++)
        {
            platformWidths[i] = theObjectPool[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < spawnPoint.position.x)
        {
            distance = Random.Range(distanceMin, distanceMax);

            platformSelector = Random.Range(0, theObjectPool.Length);

            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + distance, transform.position.y, transform.position.z);

        

            //Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation);

            
            GameObject newPlatform =  theObjectPool[platformSelector].getPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);
            
        }
		
	}
}
