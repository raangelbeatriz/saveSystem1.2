using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSettings : MonoBehaviour
{
    public float volumeValue;

    public Slider slider;

    public TextMeshProUGUI volumeText;

    public void Start()
    {
        volumeValue = PlayerPrefs.GetFloat("volume", 50);
        slider.value = volumeValue;
        volumeText.text = volumeValue.ToString("0.0");
        
    }

    public void volumeSlider()
    {
        volumeText.text = slider.value.ToString("0.0");
    }
    public void setVolumeValue()
    {
        volumeValue = slider.value;
        PlayerPrefs.SetFloat("volume", volumeValue);
        PlayerPrefs.Save();
    }

}
