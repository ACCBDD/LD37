using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour {

	private Rigidbody rb;
	public GameObject playerDebris;
	private AudioSource aud;
	public AudioClip cl;
  private ParticleSystem part;

	void Start () {
		GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 1.0f, 1.0f);
		rb = GetComponent<Rigidbody>();
		aud = GetComponent<AudioSource>();
    part = GetComponent<ParticleSystem>();
    part.randomSeed = (uint)Random.Range(0,10000);
    part.Simulate(0, true, true);
    part.Emit(20);
		rb.useGravity = false;
		rb.AddForce(transform.forward*0.1f);
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
      part.Emit(20);
			transform.position = Vector3.one * 9999999f;
		}
		Object.Destroy(gameObject, 0.5f);
	}
}
