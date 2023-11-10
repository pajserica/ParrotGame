using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SO_Enemies : ScriptableObject
{
    public string enemyName;
    public GameObject enemyModel;
    public GameObject abilityModel;
    public int maxHp;
    public float patrolSpeed; 
    public float chaseSpeed;
    public int abilityDamage;
    public float cooldownAbility;
    public EnemyMovement movementScript;


    public int id;
}
