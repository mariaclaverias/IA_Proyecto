using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/Hurt")]
public class ActionNotHurtingMe : ActionNodeView
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (((Health)_IACharacterActions.health).HurtingMe == null)
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }
}
