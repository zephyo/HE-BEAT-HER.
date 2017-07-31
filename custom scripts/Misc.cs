using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Misc : MonoBehaviour {

	// Use this for initialization
	public TextMeshProUGUI daynight;

	public IEnumerator StartCounter(string x){
		daynight.text = "";
		daynight.gameObject.SetActive (true);
		for (int i = 0; i <= x.Length; i++) {
			yield return new WaitForSeconds (0.1f);
			daynight.text = x.Substring (0, i);
		
		}
		yield return new WaitForSeconds (2f);
		for (float i = 0; i < 1f; i+=Time.deltaTime) {
			daynight.faceColor = new Color (1f, 1f, 1f, Mathf.Lerp (1f,0f,i / 1f));
			yield return new WaitForFixedUpdate ();
		}
		daynight.gameObject.SetActive (false);
	}


}
