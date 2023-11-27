using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehiculo : IACharacterControl
{
    public float RangeWander;
    public float RadiusSeparate;
    public List<Health> vehicles;

    Vector3 positionWander;
    float FrameRate = 0;
    float Rate = 4;
    public override void LoadComponent()
    {
        base.LoadComponent();
        positionWander = RandoWander(transform.position, RangeWander);
    }
    public virtual void LookEnemy()
    {
        if (AIEye.ViewEnemy == null) return;

        //Quaternion rot = Quaternion.LookRotation(AIEye.ViewEnemy.transform.position);
        //rot.x = 0;
        //rot.z = 0;
        //transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * 50);
    }
    public virtual void MoveToPosition(Vector3 pos)
    {
        agent.SetDestination(pos);
    }
    public virtual void MoveToEnemy()
    {
        if (AIEye.ViewEnemy == null) return;
        MoveToPosition(AIEye.ViewEnemy.transform.position);
    }
    public virtual void MoveToAllied()
    {
        if (AIEye.ViewAllie == null) return;
        MoveToPosition(AIEye.ViewAllie.transform.position);
    }
    public virtual void MoveToEvadEnemy()
    {
        if (AIEye.ViewEnemy == null) return;
        Vector3 dir = (transform.position - AIEye.ViewEnemy.transform.position).normalized;
        Vector3 newPosition = transform.position + dir * 5f;
        MoveToPosition(newPosition);
    }

    Vector3 RandoWander(Vector3 position, float range)
    {
        Vector3 randP = Random.insideUnitSphere * range;
        randP.y = transform.position.y;
        return position + randP;
    }
    public virtual void MoveToWander()
    {
        if (AIEye.ViewEnemy != null) return;
        

        float distance = (transform.position - positionWander).magnitude;

        if(distance<2)
        {
            positionWander = RandoWander(transform.position, RangeWander);
        }

        if(FrameRate>Rate)
        {
            FrameRate = 0;
            positionWander = RandoWander(transform.position, RangeWander);
        }
        FrameRate += Time.deltaTime;


        MoveToPosition(positionWander);
    }

    public virtual void SeparateToAllie()
    {
        float desiredSeparation = RadiusSeparate * 2;
        Vector3 sum = Vector3.zero;
        int count = 0;

        foreach (var item in vehicles)
        {
            if (this.gameObject.GetInstanceID() != item.gameObject.GetInstanceID())
            {
                Vector3 direccion = (item.transform.position - transform.position);
                float d = direccion.magnitude;

                if (d > 0 && d < desiredSeparation)
                {
                    Vector3 diff = (transform.position - item.transform.position);
                    diff.Normalize();
                    diff /= d;

                    sum += diff;
                    count++;
                }
            }
        }

        if (count > 0)
        {
            sum /= count;
            sum.Normalize();
        }

        MoveToPosition(sum);
    }
}
