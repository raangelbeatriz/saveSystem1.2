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
        Debug.Log(dataPath + "/" + activeSave.getSaveName() + ".save");
        Load();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DeleteSavedFile();
        }
    }

    public void Save()
    {
        var serializer = new XmlSerializer(typeof(SaveData)); //Type of element you're saving
        var stream = new FileStream(dataPath + "/" + activeSave.getSaveName() + ".save", FileMode.Create); //Where you're saving

        serializer.Serialize(stream, activeSave); //Where and the object
        stream.Close();

        Debug.Log("Saved");
    }

    public void Load()
    {
        if (System.IO.File.Exists(dataPath + "/" + activeSave.getSaveName() + ".save"))
        {
            var serializer = new XmlSerializer(typeof(SaveData)); //Type of element you're saving
            var stream = new FileStream(dataPath + "/" + activeSave.getSaveName() + ".save", FileMode.Open);

            activeSave = serializer.Deserialize(stream) as SaveData;
            stream.Close();

            hasLoad = true;
        }
    }

    public void DeleteSavedFile()
    { 

        if (System.IO.File.Exists(dataPath + "/" + activeSave.getSaveName() + ".save"))
        {
            File.Delete(dataPath + "/" + activeSave.getSaveName() + ".save");
            Debug.Log("Deleted");
        }
    }
}
