using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : AttackPlayer
{

    [SerializeField] List<Transform> spawnAbilityPositions;



    public override void Attack(){
        // Animation
        isAttacking = true;
        Invoke("CastAbility", firstCastWaitTime);
        if(repeatCastAfter != 0)
            InvokeRepeating("CastAbility", firstCastWaitTime, repeatCastAfter);
    }

    private void CastAbility(){
        foreach(Transform point in spawnAbilityPositions){
            Instantiate(abilityObject, point.position, point.rotation);
        }
        Debug.Log(gameObject);
    }


    


}
