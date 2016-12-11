using UnityEngine;
using System.Collections;

public class CollideSound : MonoBehaviour {

	private AudioSource aud;
	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void OnCollisionEnter () {
		aud.Play();
	}
}
