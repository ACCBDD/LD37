using UnityEngine;
using System.Collections;

public class PointAtPlayer : MonoBehaviour {

	public GameObject player;

	void Start () {
		player = GameObject.FindWithTag("Player");
	}

	void Update () {
		if (player != null)
			transform.LookAt(player.transform);
	}
}
