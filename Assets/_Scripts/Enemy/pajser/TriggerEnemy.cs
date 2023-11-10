using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : MonoBehaviour
{
    [SerializeField] EnemyController ctrlScript;


    void OnTriggerEnter(Collider coll){
        if(coll.tag == "Player"){
            ctrlScript.GetInfo(coll.gameObject.transform);
        }
    }
}
