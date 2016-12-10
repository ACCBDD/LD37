using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 1.0f, 1.0f);
		rb = GetComponent<Rigidbody>();
		rb.useGravity = false;
		rb.AddForce(transform.forward*0.2f);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter() {
		Object.Destroy(gameObject);
	}
}
