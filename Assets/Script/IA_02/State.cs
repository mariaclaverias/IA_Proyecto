using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public TypeState type;
    public EngineState _EngineState;
    public virtual void Enter() { }
    public virtual void Execute() { }
    public virtual void Exit() { }

    public virtual void LoadComponent()
    {
        _EngineState = GetComponent<EngineState>();
    }
}
