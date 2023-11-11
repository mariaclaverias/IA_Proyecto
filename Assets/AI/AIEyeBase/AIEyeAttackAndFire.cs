using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEyeAttackAndFire : AIEyeAttack
{
    private void Start()
    {
        LoadComponent();
    }

    private void Update()
    {
        UpdateScan();
    }

    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    public override void UpdateScan()
    {
        base.UpdateScan();
    }

    private void OnValidate()
    {
        mainDataView.CreateMesh();
        DataViewAttack.CreateMesh();
    }
    private void OnDrawGizmos()
    {
        mainDataView.OnDrawGizmos();
        DataViewAttack.OnDrawGizmos();
    }
}
