using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSetting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider bgmSlider;

    public const string MIXER_BGM = "BGMVolume";

    void Awake()
    {
        bgmSlider.onValueChanged.AddListener(setBGMVolume);
    }

    void Start()
    {
        bgmSlider.value = PlayerPrefs.GetFloat(AudioManager.BGM_KEY, bgmSlider.value);
    }

    public void setBGMVolume(float volume)
    {
        audioMixer.SetFloat(MIXER_BGM, Mathf.Log10(volume) * 20);
    }
}
