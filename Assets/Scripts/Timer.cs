using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	private string centiSecond;
	private string seconds;
	private string minutes;
	public Text textBox;

	// Update is called once per frame
	void Update () {
		centiSecond = Mathf.Round((Time.timeSinceLevelLoad * 100) % 100).ToString();
		if (int.Parse(centiSecond) < 10) { centiSecond = "0" + centiSecond; }
		seconds = Mathf.Round(Time.timeSinceLevelLoad % 60).ToString();
		if (int.Parse(seconds) < 10) { seconds = "0" + seconds.ToString(); }
		minutes = Mathf.Floor(Time.timeSinceLevelLoad/60).ToString();
		if (int.Parse(minutes) < 10) { minutes = "0" + minutes; }

		textBox.text = minutes + ":" + seconds + "." + centiSecond;
	}
}
