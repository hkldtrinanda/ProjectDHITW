using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    [SerializeField] Image SoundOn;
    [SerializeField] Image SoundOff;

    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", 1);
            Load();
        }

        {
            Load();
        }

        if (!PlayerPrefs.HasKey("Muted"))
        {
            PlayerPrefs.SetInt("Muted", 0);
            Load();
        }

        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume()
    {
            AudioListener.volume = volumeSlider.value;
            Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        muted = PlayerPrefs.GetInt("Muted") == 1;
    }
    
    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        PlayerPrefs.SetInt("Muted", muted ? 1 : 0);
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            SoundOn.enabled = true;
            SoundOff.enabled = false;
        }
        else
        {
            SoundOn.enabled = false;
            SoundOff.enabled = true;
        }

    }
    

    
}
