using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class SaveManager : MonoBehaviour
{
    public static SaveManager sv;

    public SaveData activeSave;

    private string dataPath;

    public void Awake()
    {
        sv = this;
        dataPath = Application.persistentDataPath;
    }

    public void Update()
    {

    }

    public void Save()
    {
        //var stream = new FileStream(dataPath + "/" + activeSave.getSaveName() + ".save", FileMode.Create);
    }

    public void Load()
    {

    }

    public void DeleteSavedFile()
    { 

    }
}
