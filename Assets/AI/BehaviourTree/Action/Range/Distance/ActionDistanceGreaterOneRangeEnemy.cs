using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/ Node Range / Distance")]
public class ActionDistanceGreaterOneRangeEnemy : ActionDistanceRange
{
        public override void OnStart()
        {
            base.OnStart();
            unitGame = this._AICharacterControl.Health._Unity;

        }
        public override TaskStatus OnUpdate()
        {
            float distance = _AICharacterControl.AIEye.DistanceEnemy;
            switch (unitGame)
            {
                case UnitGame.Zombie:
                if (distance > distanceOneLand/*||distance>distanceOneFly*/)
                    return TaskStatus.Success;
                    break;
                
                default:
                    break;
            }

            return TaskStatus.Failure;
        }
        //public override UnitSC GetTypeUnity()
        //{
        //    if (_AICharacterControl.AIEye.ViewEnemy != null)
        //        return _AICharacterControl.AIEye.ViewEnemy._Unity;
        //    return UnitSC.None;
        //}


}
