using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EvilWord : MonoBehaviour {

	private float spawnTimer = 0.25f;
	public Text evilText;
	private string[] evilWords;
	// Use this for initialization
	void Start () {
		evilWords = new string[] {"HATE", "PAIN", "WAR", "SUFFER", "KILL", "DESTROY", "SLAUGHTER", "EVIL", "SICKNESS", "EVIL", "FOUL", "UNCLEAN", "FILTH", "PLAGUE", "VILE", "ANGER", "DIE", "FAIL", "UGLY", "HURT",
															"ABUSE", "DEATH", "HORROR", "CHAOS", "LAZY", "CRIMINAL", "ANARCHY", "CHEAT", "MOCKERY", "SIN", "UNHOLY", "WRATH", "FURY", "PRIDE", "CORRUPT"};
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag("Player") != null) {
			spawnTimer -= Time.deltaTime;
			if (spawnTimer <= 0) {
				spawnTimer = 0.05f;
				evilText.text = evilWords[Random.Range(0, evilWords.Length)];
			}
		} else {
			evilText.text = null;
		}
	}
}
