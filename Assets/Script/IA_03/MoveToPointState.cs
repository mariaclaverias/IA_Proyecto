using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPointState : MoveState
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
        //if (Target != null)
        //{
        //    base.LookTarget(Target);
        //    base.MoveToPosition(Target);
        //}

    }
}
