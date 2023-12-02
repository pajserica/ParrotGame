using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalebAttack : AttackPlayer
{

    public Transform player;
    public float accelerationTime; // Time taken to accelerate
    [SerializeField] private float maxAttackSpeed = 23f;
    private float startSpeed;
    private float currentTimer;
    private bool accelerating;

    // Start is called before the first frame update
    void Start()
    {
        attackFinished = true;
        accelerating = true;
        startSpeed = agent.speed;
        accelerationTime = range / 16f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!attackFinished){
            Vector3 directionToPlayer = player.position - transform.position;
            Vector3 horizontalDirection = new Vector3(directionToPlayer.x, 0f, directionToPlayer.z);

            // Check if accelerating or decelerating based on the distance to the player
            if (accelerating)
            {
                currentTimer += Time.deltaTime;
                agent.speed = Mathf.Lerp(agent.speed, maxAttackSpeed, currentTimer / accelerationTime);
                if(currentTimer >= accelerationTime)
                    accelerating = false;
            }
            else // Decelerating
            {
                currentTimer -= Time.deltaTime;
                agent.speed = Mathf.Lerp(agent.speed, startSpeed, (accelerationTime - currentTimer) / accelerationTime);
                

                if (currentTimer <= 0)
                {
                    currentTimer = 0;
                    attackFinished = true;
                }
            }
        }
    }

    public override void Attack(Transform playerTransform){
        attackFinished = false;
        player = playerTransform;
        accelerating = true;
        Vector3 directionOfAttack = (playerTransform.position - transform.position).normalized;
        agent.SetDestination(playerTransform.position + directionOfAttack * range);

    }
}
