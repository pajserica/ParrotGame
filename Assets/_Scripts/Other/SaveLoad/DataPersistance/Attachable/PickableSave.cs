using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableSave : MonoBehaviour, IDataPersistance
{
    [SerializeField] private string id;

    public bool isCollected = false;

    public void LoadData(GameData data)
    {
        data.itemsCollected.TryGetValue(id, out isCollected);
        if(isCollected)
        {
            gameObject.transform.position = new Vector3(-1000, 1000, 1000);
        }
    }

    public void SaveData(ref GameData data)
    {
        if (data.itemsCollected.ContainsKey(id))
        {
            data.itemsCollected.Remove(id);
        }
        data.itemsCollected.Add(id, isCollected);
    }

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
