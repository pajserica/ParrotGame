using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerIdleState<EState> : BaseState<EState> where EState : Enum
{

    PlayerSM playerScr;

    public PlayerIdleState(EState enumState) : base(enumState)
    {
        
    }

    public override void EnterState(){
        Debug.Log("enter PlayerIdle");
    }

    public override void ExitState(){
        Debug.Log("exit PlayerIdle");
    }

    public override void UpdateState(){

    }

    public override EState GetNextState(){
        return StateKey;
    }

}
