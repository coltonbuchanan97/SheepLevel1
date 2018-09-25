using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;

    private Vector3 lastPlayerPos;
    private float distance;

	// Use this for initialization
	void Start () {
        lastPlayerPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        distance = player.transform.position.x - lastPlayerPos.x;
        transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
        lastPlayerPos = player.transform.position;
	}
}
