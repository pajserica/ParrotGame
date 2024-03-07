using UnityEngine;

public class EnemyAttackState : EnemyBaseState
{
    float tempAttackTime;

    public override void EnterState(EnemyStateManager enemy){
        enemy.attackScript.Attack(enemy.playerTransform);
        // Debug.Log("State attacking ");
    }
    public override void UpdateState(EnemyStateManager enemy){
        if(!enemy.attackScript.attackFinished){
            Debug.Log("not finished...");
        }
        else{
            Debug.Log("finished...");
            if (enemy.playerTransform)
                enemy.SwitchState(enemy.ChaseState);
            else
                enemy.SwitchState(enemy.IdleState);
        }   
    }
    public override void OnTriggerEnter(EnemyStateManager enemy){
        
    }
    public override void OnTriggerExit(EnemyStateManager enemy){
        
    }

}
