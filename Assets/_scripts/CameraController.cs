﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// control the camer
public class CameraController : MonoBehaviour {
    public PlayerController player;
    public bool isFollowing;

    public float xOffset;
    public float yOffset;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerController>();
        //camera is following player
        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFollowing)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y      + yOffset,transform.position.z);
        }
	}
}
