using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : MonoBehaviour, IAttackPlayer
{

    
    [SerializeField] float animationDuration;
    [SerializeField] float range;
    [SerializeField] float abilitySpeed;
    [SerializeField] GameObject abilityObject;



    // Start is called before the first frame update
    void Start()
    {
        Attack();
    }

    public void Attack(){
        // Animation
        Invoke("CastAbility", animationDuration); 
    }

    private void CastAbility(){
        Instantiate(abilityObject, transform.position, transform.rotation);
    }

    


}
