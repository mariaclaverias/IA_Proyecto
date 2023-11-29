using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehiculoZombie : IACharacterVehiculo
{
    void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public override void LookPosition(Vector3 position)
    {
        base.LookPosition(position);
    }

    public override void MoveToPosition(Vector3 pos)
    {
        base.MoveToPosition(pos);
    }

    public override void MoveToWander()
    {
        base.MoveToWander();
    }

    public override void MoveToEnemy()
    {
        base.MoveToEnemy( );
    }
    public override void MoveToAllied()
    {
        base.MoveToAllied( );
    }
    public override void MoveToEvadEnemy()
    {
        base.MoveToEvadEnemy( );
    }

}
