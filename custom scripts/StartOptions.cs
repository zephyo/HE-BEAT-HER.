using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using Fungus;
using UnityEngine.UI;

public class StartOptions : MonoBehaviour {



	public int sceneToStart = 1;										//Index number in build settings of scene to load if changeScenes is true
											//If true, load a new scene when Start is pressed, if false, fade out UI and continue in single scene
	public bool changeMusicOnStart;										//Choose whether to continue playing menu music or start a new music clip

	public AudioSource x;


	public Image foreground, Title;
	public float damper;


	[HideInInspector] public bool inMainMenu = true;					//If true, pause button disabled in main menu (Cancel in input manager, default escape key)
				//Reference to animator that will fade out alpha of MenuPanel canvas group
	public Animator anim;	//Animation clip fading out UI elements alpha


										//Reference to PlayMusic script
	private float fastFadeIn = .01f;									//Very short fade time (10 milliseconds) to start playing music immediately without a click/glitch
	private ShowPanels showPanels;										//Reference to ShowPanels script on UI GameObject, to show and hide panels
	float xx;

	Vector2 orig, origTitle;
	
	void Awake()
	{
		//Get a reference to ShowPanels attached to UI object
		showPanels = GetComponent<ShowPanels> ();

		//Get a reference to PlayMusic attached to UI object
		orig=foreground.rectTransform.anchoredPosition;
		origTitle=Title.rectTransform.anchoredPosition;
		anim.SetFloat ("Speed", -2f);
		StartCoroutine (stop ());
		DontDestroyOnLoad (x);
	}
	void Start(){
		x.Play ();
	}

	IEnumerator stop(){
		yield return new WaitForSeconds (1.25f);
		anim.enabled = false;
		anim.SetFloat ("Speed", 1f);
	}

	void FixedUpdate(){
		xx = Input.mousePosition.x;
		if (!(xx <= 0 || xx > Screen.width - 1)) {
			xx -= Screen.width / 2;
			foreground.rectTransform.anchoredPosition = new Vector2 (xx * damper, orig.y);
			Title.rectTransform.anchoredPosition = new Vector2 (xx * damper * damper, origTitle.y);
		}
	
	
	}
	public void StartButtonClicked()
	{
		//If changeMusicOnStart is true, fade out volume of music group of AudioMixer by calling FadeDown function of PlayMusic, using length of fadeColorAnimationClip as time. 
		//To change fade time, change length of animation "FadeToColor"
		StartCoroutine (xxs ());

			//Use invoke to delay calling of LoadDelayed by half the length of fadeColorAnimationClip

	
			//Set the trigger of Animator animColorFade to start transition to the FadeToOpaque state.
		
		anim.enabled = true;
	

	}
	IEnumerator xxs(){
		for (float i = 0; i < 1f; i+=Time.deltaTime) {
			x.volume = Mathf.Lerp (0.9f, 0.55f, i / 1f);
			yield return new WaitForEndOfFrame ();
		}
		x.volume = 0.55f;
		yield return new WaitForSeconds (0.1f);
		LoadDelayed ();
	}


	public void newgame(){
		FungusManager.Instance.SaveManager.ClearHistory();

//		if (string.IsNullOrEmpty(saveManager.StartScene))
//		{
//			Debug.LogError("No start scene specified");
//			return;
//		}
//	
//		// Reset the Save History for a new game
//		saveManager
		StartButtonClicked ();
	}

	public void LoadDelayed()
	{
		//Pause button now works if escape is pressed since we are no longer in Main menu.
		inMainMenu = false;

		//Hide the main menu UI element
		showPanels.HideMenu ();

		//Load the selected scene, by scene index number in build settings
		SceneManager.LoadScene (sceneToStart);
	}

	public void HideDelayed()
	{
		//Hide the main menu UI element after fading out menu for start game in scene
		showPanels.HideMenu();
	}



}
