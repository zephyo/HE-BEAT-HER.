using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talkingguy : MonoBehaviour {

	public Sprite reg, pissed, thought;
	public Sprite reghalf, regclosed, pissedhalf, pissedclosed, thoughthalf, thoughtclosed;
	public Image x;


	public void regg(){
		x.sprite = reg;
		blink ();
	}
	public void pissedg(){
		x.sprite = pissed;
		blink ();

	}
	public void hought(){
		x.sprite = thought;
		blink ();
	}

	public void blink(){
		StartCoroutine (blinkhj ());
	}
	IEnumerator blinkhj(){
		yield return new WaitForSeconds (0.5f);
		switch (x.sprite.name) {
		case "talking":
			x.sprite = reghalf;
			yield return new WaitForSeconds (0.12f);
			x.sprite = regclosed;
			yield return new WaitForSeconds (0.4f);
			x.sprite = reghalf;
			yield return new WaitForSeconds (0.2f);
			x.sprite=reg;
			break;
		case "talkingpissed":
			x.sprite = pissedhalf;
			yield return new WaitForSeconds (0.12f);
			x.sprite = pissedclosed;
			yield return new WaitForSeconds (0.4f);
			x.sprite = pissedhalf;
			yield return new WaitForSeconds (0.2f);
			x.sprite=pissed;
			break;

		case "talkingthoughtful":
			x.sprite = thoughthalf;
			yield return new WaitForSeconds (0.12f);

			x.sprite = thoughtclosed;
			yield return new WaitForSeconds (0.4f);
			x.sprite = thoughthalf;
			yield return new WaitForSeconds (0.2f);
			x.sprite=thought;
			break;
		default:
			break;
		}
	}
}
