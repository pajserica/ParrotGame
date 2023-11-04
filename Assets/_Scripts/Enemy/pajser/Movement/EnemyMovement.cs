using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] 
public abstract class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    private Transform objectEntered;

    void Awake(){
        agent = GetComponent<NavMeshAgent>();
        Debug.Log(agent + "base");
    }

    public void GetInfo(Transform _transform){
        objectEntered = _transform;
        if(objectEntered.gameObject.tag == "Player"){
            StartMovement(objectEntered);
        }
    }

    public abstract void StartMovement(Transform z);
}
