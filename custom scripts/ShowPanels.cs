using UnityEngine;
using System.Collections;

public class ShowPanels : MonoBehaviour {

							//Store a reference to the Game Object OptionsPanel 
						//Store a reference to the Game Object OptionsTint 
	public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
	public GameObject pausePanel;	
	public AudioSource x;//Store a reference to the Game Object PausePanel 


	//Call this function to activate and display the Options panel during the main menu
	public void ShowOptionsPanel(CanvasGroup optionsPanel)
	{
		optionsPanel.gameObject.SetActive(true);
		LeanTween.value(optionsPanel.gameObject, optionsPanel.alpha, 1f, 0.5f).setOnUpdate( (t) => { 
			optionsPanel.alpha = t;
		}).setOnComplete( () => {
			optionsPanel.alpha = 1f;

		});
	}

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideOptionsPanel(CanvasGroup optionsPanel)
	{
		LeanTween.value(optionsPanel.gameObject, optionsPanel.alpha, 0f, 0.5f).setOnUpdate( (t) => { 
			optionsPanel.alpha = t;
		}).setOnComplete( () => {
			optionsPanel.alpha = 0f;
			optionsPanel.gameObject.SetActive(false);
		});
	

	}

	//Call this function to activate and display the main menu panel during the main menu
	public void ShowMenu()
	{
		menuPanel.SetActive (true);
	}

	//Call this function to deactivate and hide the main menu panel during the main menu
	public void HideMenu()
	{
		menuPanel.SetActive (false);
	}
	

	//Call this function to deactivate and hide the Pause panel during game play
	public void Resume()
	{
		pausePanel.SetActive (false);
	

	}


	public void PlayAudios(AudioClip y){
		x.PlayOneShot (y, 1f);
	}



}
