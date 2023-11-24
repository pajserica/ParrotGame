using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int savedInt;
    public Vector3 savedVector3;
    public SerializableDictionary<string, bool> itemsCollected;

    public GameData()
    {
        savedInt = 0;
        savedVector3 = Vector3.zero;
        itemsCollected = new SerializableDictionary<string, bool>();
    }
}
