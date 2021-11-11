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

    public bool hasLoad = false;


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
        var serializer = new XmlSerializer(typeof(SaveData));
        var stream = new FileStream(dataPath + "/" + activeSave.getSaveName() + ".save", FileMode.Create);

        serializer.Serialize(stream, activeSave);
        stream.Close();

        Debug.Log("Saved");
    }

    public void Load()
    {

    }

    public void DeleteSavedFile()
    { 

    }
}
