using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;

    public AudioMixer audioMixer;

    void Start()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
            PlayerPrefs.SetFloat("MusicVolume", 0f);

        if (!PlayerPrefs.HasKey("SFXVolume"))
            PlayerPrefs.SetFloat("SFXVolume", 0f);

        float musicVol = PlayerPrefs.GetFloat("MusicVolume");
        float sfxVol = PlayerPrefs.GetFloat("SFXVolume");

        musicSlider.value = musicVol;
        sfxSlider.value = sfxVol;

        audioMixer.SetFloat("MusicVolume", musicVol);
        audioMixer.SetFloat("SFXVolume", sfxVol);
    }

    public void SetMusicVolume()
    {
        float vol = musicSlider.value;

        audioMixer.SetFloat("MusicVolume", vol);
        PlayerPrefs.SetFloat("MusicVolume", vol);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume()
    {
        float vol = sfxSlider.value;

        audioMixer.SetFloat("SFXVolume", vol);
        PlayerPrefs.SetFloat("SFXVolume", vol);
        PlayerPrefs.Save();
    }
}