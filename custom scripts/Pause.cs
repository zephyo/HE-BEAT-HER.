using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Pause : MonoBehaviour {

	AudioSource x;
	public AudioSource sfxx, local;
	public AudioMixerSnapshot fadedown, fadeup;


	int time;

	public void Start(){
		x = GameObject.FindGameObjectWithTag ("Audio").GetComponent<AudioSource>();
	}

	public void PlayAudios(AudioClip y){
		sfxx.PlayOneShot (y, 1f);
	}



	public void SwitchAudio(AudioClip y){


		StartCoroutine (aud (y));
	}

	public void SwitchAudioBack(){
		StartCoroutine (aud2 ());
	}

	IEnumerator aud(AudioClip y){
		fadedown.TransitionTo (0.6f);
		yield return new WaitForSeconds (0.6f);
		x.Pause ();
		local.clip = y;

		local.Play ();

		fadeup.TransitionTo (0.5f);
	}

	IEnumerator aud2(){
		fadedown.TransitionTo (0.6f);
		yield return new WaitForSeconds (0.6f);
		local.Stop ();
		x.UnPause ();
		fadeup.TransitionTo (0.5f);
	}

	public void Pauseing(){
		Time.timeScale = 0f;
	}
	public void UnPauseing(){
		Time.timeScale = 1f;
	}
	public void ShowPausePanel(CanvasGroup PausePanel)
	{
		PausePanel.alpha = 0f;PausePanel.gameObject.SetActive(true);
		LeanTween.value(PausePanel.gameObject, PausePanel.alpha, 1f, 0.5f).setOnUpdate( (t) => { 
			PausePanel.alpha = t;
		}).setOnComplete( () => {
			PausePanel.alpha = 1f;

		});
	}

	//Call this function to deactivate and hide the Pause panel during the main menu
	public void HidePausePanel(CanvasGroup PausePanel)
	{
		LeanTween.value(PausePanel.gameObject, PausePanel.alpha, 0f, 0.5f).setOnUpdate( (t) => { 
			PausePanel.alpha = t;
		}).setOnComplete( () => {
			PausePanel.alpha = 0f;
			PausePanel.gameObject.SetActive(false);
		});


	}

	public void MainMenu(){
		Destroy (x.gameObject);
		SceneManager.LoadScene (0);
	}

	public void Quit()
	{
		//If we are running in a standalone build of the game
		#if UNITY_STANDALONE
		//Quit the application
		Application.Quit();
		#endif

		//If we are running in the editor
		#if UNITY_EDITOR
		//Stop playing the scene
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}


}
