using UnityEngine;
using UnityEngine.AI; 

public class EnemyAI : MonoBehaviour
{
    [Header("AI Attributes")]
    public float detectionRange = 10.0f; 
    public float attackRange = 2.0f; 

    private NavMeshAgent navAgent; 
    private Transform playerTarget; 
    private bool isChasing = false;

    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        playerTarget = FindObjectOfType<Player>().transform; 
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerTarget.position);

        if (distanceToPlayer <= detectionRange)
        {
            isChasing = true;
            ChasePlayer();
        }
        else if (isChasing && distanceToPlayer > detectionRange)
        {
            isChasing = false;
            StopChasingPlayer();
        }

        if (isChasing && distanceToPlayer <= attackRange)
        {
            AttackPlayer();
        }
    }

    private void ChasePlayer()
    {
        navAgent.SetDestination(playerTarget.position); 
    }

    private void StopChasingPlayer()
    {
        navAgent.ResetPath(); 
    }

    private void AttackPlayer()
    {
        
    }

}
