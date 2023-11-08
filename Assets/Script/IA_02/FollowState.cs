using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowState : MoveState
{
    void Start()
    {
        LoadComponent();
    }

    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    public override void Execute()
    {
        if (IAEye.enemy != null)
        {
            base.MoveToPosition(IAEye.enemy.position);
        }
        else
        {
            _EngineState.activateState(TypeState.Follow);
            return;
        }    
    }
}
