using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveState : State
{
    protected NavMeshAgent agent;
    protected SensorView IAEye;


    public override void LoadComponent()
    {
        agent = GetComponent<NavMeshAgent>();
        IAEye = GetComponent<SensorView>();
        base.LoadComponent();
    }

    public virtual void MoveToPosition(Vector3 pos)
    {
        agent.SetDestination(pos);
    }
}