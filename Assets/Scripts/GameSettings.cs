using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSettings : MonoBehaviour
{
    public float volumeValue;

    public static GameSettings gameSettings;

    public void Awake()
    {
        if (gameSettings == null)
        {
            DontDestroyOnLoad(gameObject);
            gameSettings = this;
        }
        else
        {
            Destroy(gameObject);
        }
        volumeValue = PlayerPrefs.GetFloat("volume", 50);

    }


    public void saveVolume(float value)
    {
        volumeValue = value;
        PlayerPrefs.SetFloat("volume", volumeValue);
        PlayerPrefs.Save();
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }

}
