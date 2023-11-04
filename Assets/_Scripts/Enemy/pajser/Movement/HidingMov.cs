using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingMov : EnemyMovement
{
    private Transform enemyTransform;
    public override void StartMovement(Transform _transform){
        Debug.Log(this.gameObject);
        enemyTransform = _transform;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyTransform){
            agent.SetDestination(enemyTransform.position);
            Debug.Log(enemyTransform.position);

        }
    }
}
