using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class entenr : MonoBehaviour {


	public Image decided,instruction;


	void OnEnable(){
		StartCoroutine (xx ());

	}

	IEnumerator xx(){
		yield return new WaitForSeconds (0.2f);
	Color cx = new Color (1, 1, 1, 1);

		LeanTween.color (instruction.rectTransform, cx, 0.5f);

		yield return new WaitForSeconds (1.5f);
		LeanTween.color (decided.rectTransform, cx, 0.5f);
	}

	void OnDisable() {
		
		Destroy (this.gameObject);
	}
}
