using UnityEngine;
using System.Collections;

public class SpawnHazard : MonoBehaviour {

	private float minX = -40;
	private float maxX = 40;
	private float minY = 0;
	private float maxY = 40;
	private float spawnTimer = 0;
	private int failedSpawns = 0;
	private int failedIterations = 0;
	private int layer;
	private Vector3 potentialSpawn;
	private bool successSpawn = false;

	public GameObject[] hazards;

	void Start () {
		Instantiate(hazards[0], new Vector3(Random.Range(minX + 11, maxX - 11), Random.Range(minY + 11, maxY - 11), 0), Quaternion.identity);
		layer = 1 << 8;
		layer = ~layer;
	}

	// Update is called once per frame
	void Update () {
		if (spawnTimer <= 0) {
			while (failedIterations < 20 && !successSpawn) {
				int thing = Random.Range(0, 5);
				Debug.Log("Spawning " + thing + " on loop " + failedIterations);

				switch (thing) {
					case 0: //laser turret
						potentialSpawn = new Vector3(Random.Range(minX + 11, maxX - 11), Random.Range(minY + 11, maxY - 11), 0);
						while (failedSpawns < 500 && successSpawn == false) {
							if (!Physics.CheckSphere(potentialSpawn, 3.1f, layer)) {
								Instantiate(hazards[0], potentialSpawn, Quaternion.identity);
								successSpawn = true;
							} else {
								failedSpawns += 1;
							}
						}
						break;
						case 1: //floor laser
						potentialSpawn = new Vector3(Random.Range(minX + 10f, maxX - 10f), 1.25f, 0);
						while (failedSpawns < 500 && successSpawn == false) {
							if (!Physics.CheckSphere(potentialSpawn, 10.2f, layer)) {
								Instantiate(hazards[1], potentialSpawn, Quaternion.identity);
								successSpawn = true;
							} else {
								failedSpawns += 1;
							}
						}
						break;
						case 2: //ceiling laser
						potentialSpawn = new Vector3(Random.Range(minX + 10f, maxX - 10f), 38.75f, 0);
						while (failedSpawns < 500 && successSpawn == false) {
							if (!Physics.CheckSphere(potentialSpawn, 10.2f, layer)) {
								Instantiate(hazards[2], potentialSpawn, Quaternion.Euler(0, 0, 180));
								successSpawn = true;
							} else {
								failedSpawns += 1;
							}
						}
						break;
						case 3: //left laser
						potentialSpawn = new Vector3(-39f, Random.Range(minY + 10f, maxY - 10f));
						while (failedSpawns < 500 && successSpawn == false) {
							if (!Physics.CheckSphere(potentialSpawn, 10.2f, layer)) {
								Instantiate(hazards[3], potentialSpawn, Quaternion.Euler(0, 0, -90));
								successSpawn = true;
							} else {
								failedSpawns += 1;
							}
						}
						break;
						case 4: //right laser
						potentialSpawn = new Vector3(39f, Random.Range(minY + 10f, maxY - 10f));
						while (failedSpawns < 500 && successSpawn == false) {
							if (!Physics.CheckSphere(potentialSpawn, 10.2f, layer)) {
								Instantiate(hazards[4], potentialSpawn, Quaternion.Euler(0, 0, 90));
								successSpawn = true;
							} else {
								failedSpawns += 1;
							}
						}
						break;
				}
				failedIterations += 1;
			}
			if (failedIterations >= 19) {
				spawnTimer = 0.2f;
			} else {
				spawnTimer = Random.Range(7f, 10f);
			}
			failedSpawns = 0;
			failedIterations = 0;
			successSpawn = false;
		}
		spawnTimer -= Time.deltaTime;
	}
}
