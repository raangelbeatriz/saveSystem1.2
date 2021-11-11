using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderVolume : MonoBehaviour
{
    public Slider slider;

    public TextMeshProUGUI volumeText;

    private float volumeValue;

    public void Start()
    {
        volumeValue = GameSettings.gameSettings.volumeValue;
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
        print(volumeValue);
        GameSettings.gameSettings.saveVolume(volumeValue);


    }
}
