using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/View")]
public class ActionNodeViewAllie : ActionNodeView
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if(_IACharacterVehiculo.AIEye.ViewAllie == null)
          return TaskStatus.Failure;

        return TaskStatus.Success;
    }


}