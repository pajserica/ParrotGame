using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]
//[RequireComponent(typeof(AttackPlayer))] 
public class EnemyController : MonoBehaviour
{

    EnemyMovement moveScript;
    //AttackPlayer attackScript;
    [SerializeField] List<Transform> patrollPoints;
    private Transform objectEntered;

    void Awake()
    {
        moveScript = GetComponent<EnemyMovement>();
        //attackScript = GetComponent<AttackPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GetInfo(Transform _transform)
    {
        if (!_transform.CompareTag("Player"))
            return;

        moveScript.GoToPosition(_transform);
        moveScript.followTransform(_transform);
        //if (attackScript && !attackScript.isAttacking)
            //attackScript.Attack();
    }
}
