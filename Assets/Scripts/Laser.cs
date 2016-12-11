using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour {

	private Rigidbody rb;
	public GameObject playerDebris;
	private AudioSource aud;
	public AudioClip cl;

	void Start () {
		GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 1.0f, 1.0f);
		rb = GetComponent<Rigidbody>();
		aud = GetComponent<AudioSource>();
		rb.useGravity = false;
		rb.AddForce(transform.forward*0.2f);
	}

	void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      Vector3 debrisPosition = collision.transform.position;
			Quaternion debrisRotation = collision.transform.rotation;
			Object.Destroy(collision.gameObject);
			Instantiate(playerDebris, debrisPosition, debrisRotation);
    } else {
			aud.clip = cl;
			aud.Play();
			transform.position = Vector3.one * 9999999f;
		}
		Object.Destroy(gameObject, cl.length);
	}
}
