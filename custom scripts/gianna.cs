using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gianna : MonoBehaviour {


	public Sprite one, two, three;
	public Image gia;
	int counter;
	void OnEnable(){
		switch (counter) {
		case 0:
			gia.sprite = one;
			break;
		case 1:
			gia.sprite = two;
			break;
		case 2:
			gia.sprite = three;
			counter = 0;
			break;
		default:
			counter = 0;
			break;
		}
		counter++;
	}
}
