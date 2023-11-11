using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/Node Attack")]
public class ActionAttack : ActionNodeAction
{
    IACharacterAction _AICharacterAction;
    public override void OnStart()
    {
        base.OnStart();
        _AICharacterAction = GetComponent<IACharacterAction>();
    }
    public override TaskStatus OnUpdate()
    {
        if (_AICharacterAction.Health.IsDead)
            return TaskStatus.Failure;

        SwitchAttack();
        return TaskStatus.Success;
        
    }
    void SwitchAttack()
    {
        switch (unitGame)
        {
            case UnitGame.Zombie:
                if (_AICharacterAction is AICharacterActionIAZombie)
                {
                    ((AICharacterVehicleIAZombie)_AICharacterVehicle).StopAgent();
                    ((AICharacterVehicleIAZombie)_AICharacterVehicle).LookToEnemy();
                    ((AICharacterActionIAZombie)_AICharacterAction).Attack();
                }
                break;

            
            default:

                break;
        }
    }

}
