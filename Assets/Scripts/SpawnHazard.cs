using UnityEngine;
using System.Collections;

public class SpawnHazard : MonoBehaviour {

	private float minX = -40;
	private float maxX = 40;
	private float minY = 0;
	private float maxY = 40;
	private float spawnTimer = 0;

	public GameObject[] hazards;

	void Start () {
		Instantiate(hazards[0], new Vector3(Random.Range(minX + 5, maxX - 5), Random.Range(minY + 5, maxY - 5), 0), Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		if (spawnTimer <= 0) {
			switch (Random.Range(0, 5)) {
				case 0: //laser turret
					Instantiate(hazards[0], new Vector3(Random.Range(minX + 5, maxX - 5), Random.Range(minY + 5, maxY - 5), 0), Quaternion.identity);
					break;
				case 1: //floor laser
					Instantiate(hazards[1], new Vector3(Random.Range(minX + 7f, maxX - 7f), 1.25f, 0), Quaternion.identity);
					break;
				case 2: //ceiling laser
					Instantiate(hazards[2], new Vector3(Random.Range(minX + 7f, maxX - 7f), 38.75f, 0), Quaternion.Euler(0, 0, 180));
					break;
				case 3: //left laser
					Instantiate(hazards[3], new Vector3(-39f, Random.Range(minY + 7f, maxY - 7f), 0), Quaternion.Euler(0, 0, -90));
					break;
				case 4: //right laser
					Instantiate(hazards[4], new Vector3(39f, Random.Range(minY + 7f, maxY - 7f),  0), Quaternion.Euler(0, 0, 90));
					break;
			}
			spawnTimer = Random.Range(7f, 14f);
		}
		spawnTimer -= Time.deltaTime;
	}
}
