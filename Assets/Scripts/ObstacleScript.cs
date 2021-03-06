﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

	Rigidbody2D myRigidbody;
	float dragonXposition;
	bool isScoreAdded;

	GameManagerScript gameManager;
	// Use this for initialization
	void Start () {
		myRigidbody = gameObject.GetComponent<Rigidbody2D> ();
		myRigidbody.velocity = new Vector2 (-2.5f, 0);
		dragonXposition = GameObject.Find ("Dragon").transform.position.x;
		isScoreAdded = false;

		gameManager = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= dragonXposition) {
			if (!isScoreAdded) {
				AddScore ();
				isScoreAdded = true;
			}
		}
		if (transform.position.x <= -7f) {
			Destroy (gameObject);
		}

	}
	void AddScore(){
		gameManager.GmAddScore ();
	}
}
