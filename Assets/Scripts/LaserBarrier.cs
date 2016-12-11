using UnityEngine;
using System.Collections;

public class LaserBarrier : MonoBehaviour {

	public GameObject playerDebris;

	// Update is called once per frame
	void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      Vector3 debrisPosition = collision.transform.position;
			Quaternion debrisRotation = collision.transform.rotation;
			Object.Destroy(collision.gameObject);
			Instantiate(playerDebris, debrisPosition, debrisRotation);
    }
	}
}
