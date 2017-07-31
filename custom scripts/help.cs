using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class help : MonoBehaviour {

	public TextMeshProUGUI HELP;
	int counter;

	public void Awake(){
		counter = 0;
	}
	public void OnEnable(){
		switch (counter) {
		case 0:
			HELP.text = "You have one action.\nType any verb or noun, depending on the prompt.\nSee what happens.";
			break;
		case 1:
			HELP.text = "Still need a clue?\nTry asking or talking.";
			break;
		case 2:
			HELP.text = "Here's another hint:\nTry observing your surroundings.\nMaybe, even touching them.";
			break;
		case 3:
			HELP.text = "We're all forgetful.\nHave YOU forgotten something..?";
			break;
		default:
			HELP.text = "Hmmm. You need a walkthrough?\nHere's the input for all paths you can take:\nhttp://zephyo.tumblr.com/walkthrough";
			break;



			
			}

		counter++;
	}
}
