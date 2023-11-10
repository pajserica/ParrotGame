using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackPlayer : MonoBehaviour
{
    public float firstCastWaitTime;
    public float range;
    public float abilitySpeed;
    public float repeatCastAfter;
    public GameObject abilityObject;
    public bool isAttacking;

    public abstract void Attack();

}
