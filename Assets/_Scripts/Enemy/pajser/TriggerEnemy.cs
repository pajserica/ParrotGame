using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : MonoBehaviour
{
    public EnemyMovement MovScript;


    void OnTriggerEnter(Collider coll){
        if(coll.tag == "Player"){
            MovScript.GetInfo(coll.gameObject.transform);
        }
    }
}
