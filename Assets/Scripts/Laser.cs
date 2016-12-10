using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour {

	private Rigidbody rb;
  private Light explosion;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 1.0f, 1.0f);
		rb = GetComponent<Rigidbody>();
    explosion = GetComponent<Light>();
		rb.useGravity = false;
		rb.AddForce(transform.forward*0.2f);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      string currentSceneName = SceneManager.GetActiveScene().name;
      SceneManager.LoadScene(currentSceneName);
    }
		Object.Destroy(gameObject);
	}
}
