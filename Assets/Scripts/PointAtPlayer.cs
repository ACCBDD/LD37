using UnityEngine;
using System.Collections;

public class PointAtPlayer : MonoBehaviour {

	public GameObject player;
	public GameObject laser;
	private float spawnTimer = 5f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform);
		spawnTimer -= Time.deltaTime;
		if (spawnTimer <= 0) {
			spawnTimer = 5f;
			Instantiate(laser, transform.position, transform.rotation);
		}
	}
}
