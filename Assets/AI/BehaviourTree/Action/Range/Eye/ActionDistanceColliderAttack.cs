using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/ Node Range / Eye")]
public class ActionDistanceColliderAttack : ActionNodeAction
{
        public override void OnStart()
        {
            base.OnStart();
           
        }
    public override TaskStatus OnUpdate()
    {
        //if (_AICharacterAction.Health.IsDead) return TaskStatus.Failure;



        return SwitchUnity();
    }
    TaskStatus SwitchUnity()
    {

        switch (unitGame)
        {
            
            case UnitGame.Zombie:

                AIEyeAttack _AIEyeAttackZombie = ((AICharacterVehicleIAZombie)_AICharacterVehicle).AIEye as AIEyeAttack;

                if (_AIEyeAttackZombie != null && _AIEyeAttackZombie.DataViewAttack.Attack)
                {
                    return TaskStatus.Success;
                }


                break;
            
            case UnitGame.None:
                break;
            default:
                break;
        }

        return TaskStatus.Failure;
    }


}
