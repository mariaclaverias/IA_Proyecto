using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/Range")]
public class ActionColliderOclusionObject : ActionNodeRange
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if(_CalculateDiffuse.Collider==false)
          return TaskStatus.Failure;

        if (_CalculateDiffuse.Collider == true)
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }


}