using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour {

    public GameObject floor;
    public Transform spawnPoint;
    public float distance;

    private float floorWidth;

	// Use this for initialization
	void Start () {
        floorWidth = floor.GetComponent<BoxCollider2D>().size.x;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < spawnPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + floorWidth + distance, transform.position.y, transform.position.z);

            Instantiate(floor, transform.position, transform.rotation);
        }
		
	}
}
