using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blahblah : MonoBehaviour {

	public Sprite text, textG, note,call;
	public Image x;
	public void textt(){
		x.sprite = text;
	}
	public void texttG(){
		x.sprite = textG;
	}
	public void notet(){
		x.sprite = note;
	}
	public void callt(){
		x.sprite = call;
	}
}
