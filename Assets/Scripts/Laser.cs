﻿using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour {

	private Rigidbody rb;
	public GameObject playerDebris;

	void Start () {
		GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 1.0f, 1.0f);
		rb = GetComponent<Rigidbody>();
		rb.useGravity = false;
		rb.AddForce(transform.forward*0.2f);
	}

	void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      Vector3 debrisPosition = collision.transform.position;
			Quaternion debrisRotation = collision.transform.rotation;
			Instantiate(playerDebris, debrisPosition, debrisRotation);
			Object.Destroy(collision.gameObject);
    }
		Object.Destroy(gameObject);
	}
}
