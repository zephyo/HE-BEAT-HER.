using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Fungus;
using UnityEngine.SceneManagement;

public class input : MonoBehaviour {



	public TMP_InputField i;
	public TextMeshProUGUI inputtxt;
	public CanvasGroup inputs;
	public GameObject HE;
	public CanvasGroup HELPPING;
	public CanvasGroup GAMEOVER;
	public CanvasGroup WON;




	public void Awake(){
		inputs.alpha = 0f;
	

	}



	public void ActivateInputs(int x){
		inputs.gameObject.SetActive (true);
	
		LeanTween.value(inputs.gameObject, inputs.alpha, 1f, 0.5f).setOnUpdate( (t) => { 
			inputs.alpha = t;
		}).setOnComplete( () => {
			inputs.alpha = 1f;

		});

		switch (x) {
			
		case 0:
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput);
			i.onDeselect.AddListener (InterpretInput);
			break;
		case 1:
			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What should I discuss?";
	
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput1);
			i.onDeselect.AddListener (InterpretInput1);
			break;
//		case 2:
//			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What should I talk about?";
//
//			i.onEndEdit.RemoveAllListeners ();
//			i.onDeselect.RemoveAllListeners ();
//			i.onEndEdit.AddListener (InterpretInput2);
//			i.onDeselect.AddListener (InterpretInput2);
//			break;
//		case 3:
//			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What should I threaten with?";
//			i.onEndEdit.RemoveAllListeners ();
//			i.onDeselect.RemoveAllListeners ();
//			i.onEndEdit.AddListener (InterpretInput3);
//			i.onDeselect.AddListener (InterpretInput3);
//			break;
		case 4:
			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What to examine?";
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput4);
			i.onDeselect.AddListener (InterpretInput4);
			break;
		case 5:
			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What to think about?";
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput5);
			i.onDeselect.AddListener (InterpretInput5);
			break;
		case 6:
			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What should I grab?";
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput6);
			i.onDeselect.AddListener (InterpretInput6);
			break;
		case 7:
			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What to distract her with?";
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput7);
			i.onDeselect.AddListener (InterpretInput7);
			break;
		case 8:
			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "What to search for?";
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput8);
			i.onDeselect.AddListener (InterpretInput8);
			break;
		case 9:
			i.placeholder.GetComponent<TextMeshProUGUI> ().text = "yes or no?";
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput9);
			i.onDeselect.AddListener (InterpretInput9);
			break;
		default:
			i.onEndEdit.RemoveAllListeners ();
			i.onDeselect.RemoveAllListeners ();
			i.onEndEdit.AddListener (InterpretInput);
			i.onDeselect.AddListener (InterpretInput);
			break;


		}



	}

	public void CloseInputs(){
		
		LeanTween.value(inputs.gameObject, inputs.alpha, 0f, 0.5f).setOnUpdate( (t) => { 
			inputs.alpha = t;
		}).setOnComplete( () => {
			inputs.alpha = 0f;
			inputs.gameObject.SetActive (false);
		});
	}
	void InterpretInput(string s){
		s = s.ToLower();

		switch (s) {

		case "say":
		case "talk":
		case "speak":
		case "order":
		case "tell":
		case "quiz":
		case "question":
		case "interrogate":
		case "inquire":
		case "ask":
		case "advise":
		case "announce":
		case "argue":
		case "communicate":
		case "attend":
		case "disseminate":
			Flowchart.BroadcastFungusMessage ("ask");
			CloseInputs ();
			break;

//			Flowchart.BroadcastFungusMessage ("say");
//			CloseInputs ();
//			break;

		case "threaten":
		case "cut":
		case "hit":
		case "stab":
		case "attack":
		case "threat":
		case "torture":
		case "disparage":
			Flowchart.BroadcastFungusMessage ("threaten");
	
			break;
		case "see":
		case "observe":
		case "examine":
		case "look":
		case "watch":
		case "analyze":
		case "spectate":
		case "listen":
		case "detect":
		case "investigate":
			Flowchart.BroadcastFungusMessage ("observe");
			CloseInputs ();
			break;
		case "consider":
		case "remember":
		case "speculate":
		case "understand":
		case "recall":
		case "think":
		case "reminisce":
		case "imagine":
			Flowchart.BroadcastFungusMessage ("remember");
			CloseInputs ();
			break;
		case "keep":
		case "grab":
		case "take":
		case "touch":
		case "hold":
			Flowchart.BroadcastFungusMessage ("grab");
			CloseInputs ();
			break;

		case "dance":
			Flowchart.BroadcastFungusMessage ("dance");
			CloseInputs ();
			break;
		case "yodel":
		case "sing":
			Flowchart.BroadcastFungusMessage ("sing");
			CloseInputs ();
			break;
		case "kiss":
		case "fuck":
		case "smooch":
		case "sex":
			Flowchart.BroadcastFungusMessage ("kiss");
			CloseInputs ();
			break;
		case "jump":
			Flowchart.BroadcastFungusMessage ("jump");
			CloseInputs ();
			break;
		case "stand":
		case "leave":
		case "go":
			Flowchart.BroadcastFungusMessage ("leave");
			CloseInputs ();
			break;
		case "sleep":
		case "doze":
		case "forget":
		case "forgot":
		case "dream":
		case "sigh":
			Flowchart.BroadcastFungusMessage ("sleep");
			CloseInputs ();
			break;
		case "admire":
		case "attract":
		case "appreciate":
		case "revere":
		case "adore":
		case "stare":
		case "esteem":
		case "regard":
		case "love":
		case "like":
		case "idolize":
		case "worship":
			Flowchart.BroadcastFungusMessage ("admire");
			CloseInputs ();
			break;
		case "write":
		case "document":
		case "record":
		case "draft":
		case "design":
		case "note":
		case "jot":
		case "list":
		case "evidence":
			Flowchart.BroadcastFungusMessage ("write");
			CloseInputs ();
			break;
		case "eat":
		case "devour":
		case "snack":
		case "feed":
		case "drink":
		case "chew":
		case "ate":
		case "consume":
		case "taste":
		case "gobble":
			Flowchart.BroadcastFungusMessage ("eat");
		
			break;
		case "phone":
		case "call":
		case "text":
		case "message":
			Flowchart.BroadcastFungusMessage ("phone");
			CloseInputs ();
			break;
		case "game":
		case "play":
		case "stream":
		case "ludum":
			Flowchart.BroadcastFungusMessage ("play");

			break;
		case "meow":
		case "bark":
		case "moo":
		case "neigh":
		case "growl":
		case "squawk":
		case "roar":
		case "quack":
			Flowchart.BroadcastFungusMessage ("meow");

			break;
		case "wave":
		case "cheer":
		case "greet":
		case "gesture":
			Flowchart.BroadcastFungusMessage ("wave");

			break;
		case "belch":
		case "fart":
		case "burp":
			Flowchart.BroadcastFungusMessage ("burp");

			break;
		case "soar":
		case "glide":
		case "flap":
		case "fly":
			Flowchart.BroadcastFungusMessage ("fly");

			break;
		case "undress":
		case "naked":
		case "smell":
		case "sniff":
		case "dump":
		case "scratch":
		case "molest":
		case "harass":
		case "moon":
		case "poo":
		case "poop":
		case "pee":
		case "spit":
		case "stalk":
		case "glare":
			Flowchart.BroadcastFungusMessage ("undress");
			break;
		case "read":
		case "study":
		case "peruse":
			Flowchart.BroadcastFungusMessage ("read");
			break;

		case "die":
		case "decease":
			Flowchart.BroadcastFungusMessage ("die");
			CloseInputs ();
			break;
		case "cry":
		case "despair":
		case "panic":
		case "worry":
		case "fear":
		case "grieve":
		case "agonize":
		case "hate":
			Flowchart.BroadcastFungusMessage ("cry");
			CloseInputs ();
			break;
		case "smile":
		case "laugh":
		case "giggle":
		case "chuckle":
			Flowchart.BroadcastFungusMessage ("laugh");
			CloseInputs ();
			break;
		case "scream":
		case "shout":
		case "yell":
		case "holler":
			Flowchart.BroadcastFungusMessage ("scream");
			CloseInputs ();
			break;
		case "snort":
		case "frown":
		case "scowl":
		case "sneer":
			Flowchart.BroadcastFungusMessage ("frown");
			CloseInputs ();
			break;
		case "fucking":
		case "shit":
		case "motherfucker":
		case "crap":
		case "bitch":
		case "ass":
		case "asshole":
		case "cunt":
		case "kms":
		case "kill":
		case "kys":
		case "curse":
		case "swear":
		case "cuss":
		case "damn":
		case "censure":
		case "insult":
			Flowchart.BroadcastFungusMessage ("swear");
			CloseInputs ();
			break;
		case "sneeze":
			Flowchart.BroadcastFungusMessage ("sneeze");
			CloseInputs ();
			break;

		default:
			Flowchart.BroadcastFungusMessage ("sense");
			break;

		}

	}
	void InterpretInput1(string s){


		s = s.ToLower();

		switch (s) {
		case "abusive":
		case "abuse":
			Flowchart.BroadcastFungusMessage ("abuse");
			CloseInputs ();
			break;
		case "clothes":
		case "scar":
		case "neck":
		case "shirt":
		case "sweater":
		case "hot":
		case "incident":
		case "turtleneck":
			Flowchart.BroadcastFungusMessage ("turtleneck");
			CloseInputs ();
			break;
		case "gianna":
			Flowchart.BroadcastFungusMessage ("gianna");
			CloseInputs ();
			break;
		case "medication":
		case "records":
		case "record":
		case "medicine":
			Flowchart.BroadcastFungusMessage ("medication");
			CloseInputs ();
			break;
		case "bipolar":
		case "prescription":
			Flowchart.BroadcastFungusMessage ("bipolar");
			CloseInputs ();
			break;
		case "phone":
		case "cellphone":
		case "mobile":
		case "phones":
			Flowchart.BroadcastFungusMessage ("phones");
			CloseInputs ();
			break;
		case "sad":
		case "melancholy":
		case "cry":
			Flowchart.BroadcastFungusMessage ("sad");
			CloseInputs ();
			break;
		default:
			Flowchart.BroadcastFungusMessage ("sense");
			break;

		}

	}
//	void InterpretInput2(string s){
//		s = s.ToLower();
//
//		switch (s) {
//
//
//		case "turtleneck":
//			Flowchart.BroadcastFungusMessage ("death");
//			CloseInputs ();
//			break;
//		default:
//			Flowchart.BroadcastFungusMessage ("sense");
//			break;
//
//		}
//	}

//	void InterpretInput3(string s){
//		s = s.ToLower();
//
//		switch (s) {
//
//
//		case "turtleneck":
//			Flowchart.BroadcastFungusMessage ("death");
//			CloseInputs ();
//			break;
//		default:
//			Flowchart.BroadcastFungusMessage ("sense");
//			break;
//
//		}
//	}

	void InterpretInput4(string s){
		s = s.ToLower();

		switch (s) {

		case "girl":
		case "woman":
		case "accuser":
		case "prosecutor":
		case "lady":
			Flowchart.BroadcastFungusMessage ("girl");
			CloseInputs ();
			break;
		case "client":
		case "accused":
		case "man":
			Flowchart.BroadcastFungusMessage ("man");
			CloseInputs ();
			break;
		case "room":
		case "courtroom":
		case "place":
		case "environment":
		case "area":
		case "court":
			Flowchart.BroadcastFungusMessage ("room");
			CloseInputs ();
			break;
		default:
			Flowchart.BroadcastFungusMessage ("sense");
			break;

		}
	}


	void InterpretInput6(string s){
		s = s.ToLower();

		switch (s) {

		case "phone":
		case "cellphone":
		case "mobile":
		case "phones":
			Flowchart.BroadcastFungusMessage ("grabphones");
			CloseInputs ();
			break;
		case "purse":
		case "bag":
		case "handpurse":
		case "sack":
		case "pack":
			Flowchart.BroadcastFungusMessage ("purse");
			CloseInputs ();
			break;
		default:
			Flowchart.BroadcastFungusMessage ("sense");
			break;

		}
	}

	void InterpretInput5(string s){
		s = s.ToLower();

		switch (s) {

		case "abusive":
		case "abuse":
		case "trauma":
			Flowchart.BroadcastFungusMessage ("remabuse");
			CloseInputs ();
			break;
		case "gianna":
		case "red":
		case "redhead":
		case "redhair":
		case "hair":
			Flowchart.BroadcastFungusMessage ("remgianna");
			CloseInputs ();
			break;
		case "fact":
		case "facts":
		case "case":
		case "information":
		case "info":
		case "summary":
		case "brief":
		case "evidence":
			Flowchart.BroadcastFungusMessage ("write");
			CloseInputs ();
			break;
		default:
			Flowchart.BroadcastFungusMessage ("sense");
			break;

		}

	
	}

	void InterpretInput7(string s){
		s = s.ToLower();

		if (s=="dog" || s=="chrissa"){
			Flowchart.BroadcastFungusMessage ("grabphones2");
		}
			else {
			Flowchart.BroadcastFungusMessage ("phonefail2");
		
			}
		CloseInputs ();
		
	}

	void InterpretInput8(string s){
		s = s.ToLower();
		switch (s) {
		case "bipolar":
		case "medication":
		case "medicine":
		case "prescription":
			Flowchart.BroadcastFungusMessage ("bipolarphone");
			CloseInputs ();
			break;
		case "turtleneck":
		case "sweater":
		case "bruises":
		case "knife":
		case "incident":
		case "gianna":
			Flowchart.BroadcastFungusMessage ("giannaphone");
			CloseInputs ();
			break;
		default:
			Flowchart.BroadcastFungusMessage ("phonefail");
			CloseInputs ();
			break;

		}


	}
	void InterpretInput9(string s){
		s = s.ToLower();

		if (s=="yes" || s=="yea" || s=="yep"){
			Flowchart.BroadcastFungusMessage ("yess");
		}
		else {
			Flowchart.BroadcastFungusMessage ("noo");

		}
		CloseInputs ();

	}


	public void GAMEWON(){
		WON.alpha = 0f;
		WON.gameObject.SetActive (true);
		LeanTween.value(WON.gameObject, WON.alpha, 1f, 1.5f).setOnUpdate( (t) => { 
			WON.alpha = t;
		}).setOnComplete( () => {
			WON.alpha = 1f;

		});
	}



	public void MAINMENU(){
		SceneManager.LoadScene (0);
	}

	public void GAMEOVERED(){
		GAMEOVER.alpha = 0f;
		GAMEOVER.gameObject.SetActive (true);
		LeanTween.value(GAMEOVER.gameObject, GAMEOVER.alpha, 1f, 1.5f).setOnUpdate( (t) => { 
			GAMEOVER.alpha = t;
		}).setOnComplete( () => {
			GAMEOVER.alpha = 1f;

		});
	}

	public void STARTOVERED(){
		
		LeanTween.value(GAMEOVER.gameObject, GAMEOVER.alpha, 0f, 1f).setOnUpdate( (t) => { 
			GAMEOVER.alpha = t;
		}).setOnComplete( () => {
			GAMEOVER.alpha = 0f;
			GAMEOVER.gameObject.SetActive (false);
			Flowchart.BroadcastFungusMessage("StartOver");

		});
	}

	public void STARTOVERED2(){

		LeanTween.value(WON.gameObject, WON.alpha, 0f, 1f).setOnUpdate( (t) => { 
			WON.alpha = t;
		}).setOnComplete( () => {
			WON.alpha = 0f;
			WON.gameObject.SetActive (false);
			Flowchart.BroadcastFungusMessage("StartOver");

		});
	}


	public void OPENHELP(){
		HELPPING.alpha = 0f;
		HELPPING.gameObject.SetActive (true);
		LeanTween.value(HELPPING.gameObject, HELPPING.alpha, 1f, 0.5f).setOnUpdate( (t) => { 
			HELPPING.alpha = t;
		}).setOnComplete( () => {
			HELPPING.alpha = 1f;

		});
		
	}
	public void CLOSEHELP(){
		HE.SetActive (false);

		LeanTween.value(HELPPING.gameObject, HELPPING.alpha, 0f, 0.5f).setOnUpdate( (t) => { 
			HELPPING.alpha = t;
		}).setOnComplete( () => {
			HELPPING.alpha = 0f;
			HELPPING.gameObject.SetActive (false);
		});

	}


	void fade(){

		inputs.gameObject.SetActive (true);
		LeanTween.value(inputs.gameObject, inputs.alpha, 0f, 0.5f).setOnUpdate( (t) => { 
			inputs.alpha = t;
		}).setOnComplete( () => {
			inputs.alpha = 0f;
			inputs.gameObject.SetActive (false);
		});
	
	}
}
