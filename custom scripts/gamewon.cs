using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamewon : MonoBehaviour {
	public TextMeshProUGUI txt;
	public TextMeshProUGUI butttxt;

	string[] x = {"And you think about all the previous domestic situations you’ve seen. \nDid you not know the truth, then?", "..but did you uncover the whole truth?", "One person made a change.\nWas it enough?"};

	string[] butt = {"Go back and investigate more.", "Investigate more.", "Play again.", "Play more."};

	public void OnEnable(){

		txt.text = x [Random.Range (0, x.Length)];
		butttxt.text = butt [Random.Range (0, butt.Length)];
		
	}
}
