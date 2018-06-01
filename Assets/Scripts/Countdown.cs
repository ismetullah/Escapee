using UnityEngine;
using UnityEngine.UI;
using System;

public class Countdown : MonoBehaviour
{

	public float timeLeft = 60f;
	public Text countdown;

	// Update is called once per frame
	void Update ()
	{
		if (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			setText ();
		} else {
			FindObjectOfType<GameController> ().GameWon();
		}
	}

	private void setText(){
		int min = (int)Math.Round (timeLeft) / 60;
		int sec = (int)Math.Round (timeLeft) % 60;
		countdown.text = String.Format ("{0:D2}:{1:D2}", min, sec);
	}
}
