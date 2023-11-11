using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/Node Base")]
public class ActionNodeVehicle : ActionNode
    {
    protected IACharacterVehicle _AICharacterVehicle;
    public override void OnStart()
    {
        _AICharacterVehicle = GetComponent<IACharacterVehicle>();
        if (_AICharacterVehicle == null)
            Debug.Log("Not load component AICharacterVehicle");
        unitGame = this._AICharacterVehicle.Health._Unity;

        base.OnStart();
    }
}
