using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeState { Patroll, Follow, MoveToPosition }
public class EngineState : MonoBehaviour
{
    public State[] States;
    public State CurrentState;
    public TypeState InitTypeState;
    public void activateState(TypeState type)
    {
        if (CurrentState != null)
        {
            CurrentState.Exit();
        }
        foreach (var item in States)
        {
            if (((State)item).type == type)
            {
                ((State)item).enabled = true;
                ((State)item).Enter();
                CurrentState = ((State)item);
            }
            else
            {
                ((State)item).enabled = false;
            }
        }
    }

    void Start()
    {
        States = GetComponents<State>();
        activateState(InitTypeState);
    }

    void Update()
    {
        CurrentState.Execute();
    }
}
