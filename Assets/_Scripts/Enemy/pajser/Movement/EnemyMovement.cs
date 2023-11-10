using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] 
public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent agent;
    private Transform followThis;
    private Vector3 moveToPosition;
    bool isMoving;
    void Start(){
        agent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        if(isMoving){
            if(followThis)
                moveToPosition = followThis.position;
            agent.SetDestination(moveToPosition);
        }
        
    }


    public void followTransform(Transform T){
        isMoving = true;
        followThis = T;
    }
    public void StopFollowing(){
        followThis = null;
    }


    public void GoToPosition(Transform T){
        moveToPosition = T.position;
        isMoving = true;
    }
    public void StopMovement(){
        isMoving = false;
    }

}
