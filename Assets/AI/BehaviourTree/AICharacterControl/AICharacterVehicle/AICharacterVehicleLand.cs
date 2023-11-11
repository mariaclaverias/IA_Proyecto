using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AICharacterVehicleLand : IACharacterVehicle
{
    protected Vector3 PositionWander;
    protected NavMeshAgent agent { get ; set ; }
    
    protected int indexPath = 0;
    protected float elapsed = 0.0f;
    float currentSpeed;

    #region Rate
    protected int index = 0;
    protected float[] arrayRate;
    int bufferSize = 10;
    public float randomWaitMin = 1;
    public float randomWaitMax = 1;
    protected float Framerate = 0;
    #endregion
    public override void LoadComponent()
    {
        agent = GetComponent<NavMeshAgent>();
        currentSpeed = agent.speed;
        indexPath = 0;
        FrameRateInit();
        base.LoadComponent();
    }
    #region Calculate
    void FrameRateInit()
    {
        Framerate = 0;
        arrayRate = new float[bufferSize];
        for (int i = 0; i < arrayRate.Length; i++)
        {
            arrayRate[i] = (float)UnityEngine.Random.Range(randomWaitMin, randomWaitMax);
        }
    }
    public void UpdateSpeed(Vector3 target)
    {
        if (!this.agent.enabled) return;
        if (agent != null && !agent.isStopped)
        {
            float distance = (transform.position - target).magnitude;

            distance = (distance == 0) ? 1 : distance;

            //agent.speed = currentSpeed * speed;

            //if (distance <= character._MoveSpeedMultiplierMax)
            //{
            //    speed = character._MoveSpeedMultiplierMax / distance;
            //    speed = Mathf.Clamp01(speed);

            //    agent.speed = currentSpeed * speed;
            //}
            //else
            //agent.speed = currentSpeed;

            //Debug.Log("agent.speed: "+ agent.speed + " currentSpeed: " + currentSpeed + " distance: "+ distance + " speed: " +speed);
        }




    }
    public void UpdatePath(Vector3 position)
    {
        if (health.IsDead)
        {
            StopAgent();
            return;
        };

        elapsed += Time.deltaTime;
        if (elapsed > 1f)
        {
            elapsed -= 1.0f;
            agent.ResetPath();
            NavMeshPath path2 = new NavMeshPath();
            NavMesh.CalculatePath(transform.position, position, NavMesh.AllAreas, path2);
            agent.SetPath(path2);
        }
    }
    public bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        result = center + Random.insideUnitSphere * range;
        result.y = center.y;
        RaycastHit rayHit;
        if (Physics.Raycast(result, Vector3.down,out rayHit, 10000))
        {
            result.y = rayHit.point.y;

        }
        NavMeshHit hit;
        if (NavMesh.SamplePosition(result, out hit, 1.0f, NavMesh.AllAreas))
        {

            result = hit.position;
            Vector3 dir = (hit.position - center);

            Ray ray = new Ray(center, dir.normalized);
            RaycastHit rayHit2;
            if (Physics.Raycast(ray, out rayHit2, dir.magnitude))
            {
                result = rayHit2.point + rayHit2.normal * 2;

            }

            return true;
        }
        return false;
    }
    public override void CalculatePositionWanderEnemy()
    {

    }
    public override void CalculatePositionWander()
    {
        
    }
    public override Vector3 CalculatePositionEvade()
    {
        return Vector3.zero;
    }
    #endregion
    #region Move
    public override void MoveToPosition(Vector3 position)
    {
        
    }
    public override void MoveToPositionEvade()
    {
        
    }
    public override void MoveToPositionWanderEnemy()
    {
        
    }
    public override void MoveToPositionWander()
    {
        
    }
    public override void MoveToPositionStrafe()
    {

    }
    public override void MoveToAllied()
    {

    }
    public override void MoveToEnemy()
    {
        // movimiento :D

    }

    public void GetCenterWander()
    {
        
    }
    #endregion
    #region Agent
    public virtual void StopAgent()
    {
        
    }
    public virtual bool IsStopAgent()
    {
        return false;
    }
    public virtual void RunAgent()
    {

       
    }
    #endregion

}
