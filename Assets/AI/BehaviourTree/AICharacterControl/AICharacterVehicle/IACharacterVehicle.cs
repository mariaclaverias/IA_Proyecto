using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicle : AICharacterControl
{
    public override void LoadComponent()
    {
        base.LoadComponent();
    }


    public virtual void CalculatePositionWanderEnemy()
    {

    }
    public virtual void CalculatePositionWander()
    {

    }
    public virtual Vector3 CalculatePositionEvade()
    {
        return Vector3.zero;
    }
    public virtual void MoveToPosition(Vector3 position)
    {

    }
    public virtual void MoveToPositionEvade()
    {

    }
    public virtual void MoveToPositionWanderEnemy()
    {

    }
    public virtual void MoveToPositionWander()
    {

    }
    public virtual void MoveToPositionStrafe()
    {

    }
    public virtual void MoveToAllied()
    {

    }
    public virtual void MoveToEnemy()
    {

    }
}
