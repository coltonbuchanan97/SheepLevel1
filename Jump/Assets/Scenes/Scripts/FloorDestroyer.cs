using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour {

    public GameObject floorDestroyPoint;

	// Use this for initialization
	void Start () {
        floorDestroyPoint = GameObject.Find("FloorDestroyPoint");
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.x < floorDestroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
	}
}
