using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
public class SetAudioLevels : MonoBehaviour {

	public AudioMixer mainMixer;		

	//Used to hold a reference to the AudioMixer mainMixer
	public TextMeshProUGUI PresetLabel;

	void Awake(){
		PresetLabel.text = QualitySettings.names [QualitySettings.GetQualityLevel ()];
	}
	//Call this function and pass in the float parameter musicLvl to set the volume of the AudioMixerGroup Music in mainMixer
	public void SetMusicLevel(float musicLvl)
	{
		mainMixer.SetFloat("musicVol", musicLvl);
	}

	//Call this function and pass in the float parameter sfxLevel to set the volume of the AudioMixerGroup SoundFx in mainMixer
	public void SetSfxLevel(float sfxLevel)
	{
		mainMixer.SetFloat("sfxVol", sfxLevel);
	}


	public void NextPreset()
	{
		
		QualitySettings.IncreaseLevel();

		PresetLabel.text = QualitySettings.names [QualitySettings.GetQualityLevel ()];
	}
	public void LastPreset()
	{
		QualitySettings.DecreaseLevel();
		PresetLabel.text = QualitySettings.names [QualitySettings.GetQualityLevel ()];
	}

}
