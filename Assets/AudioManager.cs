using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : SingleTon<AudioManager>
{
    
    public AudioMixer audioMixer;
    public const string BGM_KEY = "bgmVolume";
    
    
    void LoadVolume()
    {
        float bgmVolume = PlayerPrefs.GetFloat(BGM_KEY, 1.0f);
        audioMixer.SetFloat(VolumeSetting.MIXER_BGM, Mathf.Log10(bgmVolume) * 20);
    }
}
