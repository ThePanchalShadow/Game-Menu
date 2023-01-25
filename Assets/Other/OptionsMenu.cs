using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Rendering;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void setVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void setQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void setFullScreen(bool isFullscreen)
    {
        Screen.fullScreen= isFullscreen;
        if(isFullscreen)
        {
            Debug.Log("isFullscreen");
        }
    }
}
