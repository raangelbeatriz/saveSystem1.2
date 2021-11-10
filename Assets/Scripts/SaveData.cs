using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //This property will let us see the values on inspector and let the system serialize this class
public class SaveData
{
    private string saveName = "test";
    public int coin;
    public int life;
    public Vector3 respawnPoint;

    public string getSaveName()
    {
        return saveName;
    }
}

