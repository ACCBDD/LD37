using UnityEngine;
using System.Collections;

public class StopMusic : MonoBehaviour {

	public AudioSource aud;
	
	void Update () {
		if (GameObject.FindWithTag("Player") == null) {
			aud.Stop();
		}
	}
}
