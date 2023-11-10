using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyMovement))] 
[RequireComponent(typeof(AttackPlayer))] 
public class EnemyController : MonoBehaviour
{

    EnemyMovement moveScript;
    AttackPlayer attackScript;
    [SerializeField] List<Transform> patrollPoints;
    private Transform objectEntered; 

    void Awake(){
        moveScript = GetComponent<EnemyMovement>();
        attackScript = GetComponent<AttackPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void GetInfo(Transform _transform){
        objectEntered = _transform;

        if(objectEntered.gameObject.tag == "Player"){ // place this in another func
            moveScript.GoToPosition(objectEntered);
            moveScript.followTransform(objectEntered);
            if(!attackScript.isAttacking)
                attackScript.Attack();
        }
    }

}
