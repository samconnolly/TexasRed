﻿using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public car player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x,player.transform.position.y,-10);
		}
}
