using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/Hurt")]
public class ActionNodeCheckHurt: ActionNodeAction
{ 
        public override void OnStart()
        {
            base.OnStart();
            _IACharacterActions = GetComponent<IACharacterActions>();
        }
        public override TaskStatus OnUpdate()
        {
            int health = _IACharacterActions.health.health;
            if (health < (health / 2))
            {
                return TaskStatus.Success;
            }
            return TaskStatus.Failure;
        }
    }
