using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IACharacterAction : AICharacterControl
{
    public NavMeshAgent agent;
    public Health health;

    public virtual void LoadComponent()
    {
        agent = GetComponent<NavMeshAgent>();
        health = GetComponent<Health>();
    }
}
