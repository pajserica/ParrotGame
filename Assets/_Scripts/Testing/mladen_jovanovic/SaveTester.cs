using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveTester : MonoBehaviour, IDataPersistance
{
    [SerializeField] private TextMeshProUGUI numberText;
    public int number = 0;
    public Vector3 vector3 = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            number++;
            vector3 += new Vector3(1, 1, 1);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            number--;
            vector3 -= new Vector3(1, 1, 1);
        }
        else if(Input.GetKeyDown(KeyCode.C)) 
        {
            PickableSave pcs = FindObjectOfType<PickableSave>();
            pcs.isCollected = !pcs.isCollected;
            
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("mladen_jovanovic 1");
        }
        numberText.text = number.ToString() + " - " + vector3.ToString();
    }

    public void LoadData(GameData data)
    {
        this.number = data.savedInt;
        this.vector3= data.savedVector3;
    }

    public void SaveData(ref GameData data)
    {
        data.savedInt = this.number;
        data.savedVector3 = this.vector3;
    }
}
