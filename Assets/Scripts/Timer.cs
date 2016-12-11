using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	private string centiSecond;
	private string seconds;
	private string minutes;
	private string timeOfDeath;
	public Text textBox;
	public Text deathBox;

	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag("Player") != null) {

			centiSecond = Mathf.Round((Time.timeSinceLevelLoad * 100) % 100).ToString();
			seconds = Mathf.Round(Time.timeSinceLevelLoad % 60).ToString();
			minutes = Mathf.Floor(Time.timeSinceLevelLoad/60).ToString();

			if (int.Parse(seconds) < 10) { seconds = "0" + seconds.ToString(); }
			if (int.Parse(centiSecond) < 10) { centiSecond = "0" + centiSecond; }
			if (int.Parse(minutes) < 10) { minutes = "0" + minutes; }

			textBox.text = minutes + ":" + seconds + "." + centiSecond;

		} else {
			timeOfDeath = textBox.text;
			deathBox.text = "TERMINATED IN\n" + textBox.text;
		}

	}
}
