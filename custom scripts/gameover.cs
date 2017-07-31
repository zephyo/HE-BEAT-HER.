using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameover : MonoBehaviour {

	// Use this for initialization
	public TextMeshProUGUI txt;
	public TextMeshProUGUI butttxt;


	string[] x = {"Could things have been different?", "It didn't have to be this way..", "Was there more you could've done?", "Was the ruling just?", "Was justice served?", "What if there was a better outcome?"};

	string[] butt = {"Go back and try again.", "Go back and do it again.", "Try again.","Play again.", "Rewind time.", "Get justice."};

	public void OnEnable(){
		int y = Random.Range (0, x.Length);
		int za=Random.Range (0, butt.Length);
		txt.text = x [y];
		butttxt.text = butt[za];

	

	
//			txt.text = "But could things have been different?";
//			butttxt.text = "Go back and try again.";
//			break;
//		case 1:
//			txt.text = "Still need a clue?\nTry asking or talking.";
//			break;
//		case 2:
//			txt.text = "Here's another hint:\nTry observing your surroundings.\nMaybe, even touching them.";
//			break;
//		case 3:
//			txt.text = "We're all forgetful.\nHave YOU forgotten something..?";
//			break;
//		case 4:
//		case 5:
//		default:
//			txt.text = "Maybe you need a walkthrough.\nHere's the big list of all actions you could take:\n(link)";
//			counter = -1;
//			break;
//
//
//
//
//		}
//
//		counter++;
	}
}
