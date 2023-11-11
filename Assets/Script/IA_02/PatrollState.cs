using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollState : MoveState
{
    public float Radius = 0f;
    public float Rate = 0f;
    private float FrameRate = 0f;

    Vector3 newPosition = Vector3.zero;
    public bool DrawGizmo;
    public Color ColorGizmo;

    private void Start()
    {
        LoadComponent();
        CalculateNewPosition();
        Debug.Log(newPosition);
    }

    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    void CalculateNewPosition()
    {
        newPosition = transform.position + Random.insideUnitSphere * Radius;
        newPosition.y = transform.position.y;
    }

    public override void Execute()
    {
        //if (IAEye.enemy != null)
        //{
        //    _EngineState.activateState(TypeState.Follow);
        //    return;
        //}
        //else
        //{
        //    if (FrameRate > Rate)
        //    {
        //        FrameRate = 0;

        //        CalculateNewPosition();
        //    }
        //    FrameRate += Time.deltaTime;

        //    base.MoveToPosition(newPosition);
        //}
    }
}
