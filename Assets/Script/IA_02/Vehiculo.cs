using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    public float radio;
    public float maxSpeed;
    public float Speed;
    public float RotationSpeed;
    public float radioWander;
    public ManagerIA managerIA;

    public float rateWander;
    private float frameRateWander = 0;

    public void Seek(Vector3 Target)
    {
        Vector3 direccion = (Target - transform.position).normalized;
        transform.position += direccion * Time.deltaTime * maxSpeed;
    }

    public Vector3 Arrive(Vector3 Target)
    {
        Vector3 direccion = (Target - transform.position);

        float d = direccion.magnitude;

        direccion.Normalize();

        if (d < radio)
        {
            Speed = Mathf.Clamp(d / radio, 0, radio);
        }
        else
        {
            Speed = Mathf.Lerp(Speed, maxSpeed, Time.deltaTime * 5);
        }

        return direccion * Speed;
    }

    public void LookTarget(Vector3 target)
    {
        Vector3 direction = (target - transform.position).normalized;
        transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * RotationSpeed);
    }

    public void wander()
    {
        Vector3 rnd = Vector3.zero;
        Vector3 Target = Vector3.zero;


        if (frameRateWander > rateWander)
        {
            rnd = Random.insideUnitSphere * radioWander;
            rnd.y = 0;
            Target = transform.position + transform.forward + rnd;
            frameRateWander = 0;
            transform.rotation = Quaternion.LookRotation((Target - transform.position).normalized);
        }
        frameRateWander += Time.deltaTime;

        transform.position += transform.forward * Time.deltaTime * Speed;
    }

    public Vector3 Separation()
    {
        float desiredSeparation = radio * 2;
        Vector3 sum = Vector3.zero;
        int count = 0;

        foreach (var item in managerIA.vehicles)
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

        return sum;
    }
    

    //public void followMyPath()
    //{
    //    //Seek(myPath.nextPoint(transform.position));
    //}
}
