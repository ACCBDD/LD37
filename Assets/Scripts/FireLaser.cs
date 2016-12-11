using UnityEngine;
using System.Collections;

public class FireLaser : MonoBehaviour {

	public GameObject laser;
	private float spawnTimer = 5f;

	void Update () {
		spawnTimer -= Time.deltaTime;
		transform.parent.gameObject.GetComponent<Renderer>().material.color = new Color(1f - 0.04314f * spawnTimer, 0.1843f + 0.12f * spawnTimer, 0.1843f + 0.12f * spawnTimer, 1f);
		if (spawnTimer <= 0) {
			spawnTimer = 5f;
			Instantiate(laser, transform.position, transform.rotation);
		}
	}
}
