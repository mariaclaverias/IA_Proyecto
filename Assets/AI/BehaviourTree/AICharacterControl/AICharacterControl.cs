using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacterControl : MonoBehaviour
{
    protected AIEyeBase _AIEye { get; set; }
    protected Health health { get; set; }
    public AIEyeBase AIEye { get => _AIEye; set => _AIEye = value; }
    public Health Health { get => health; set => health = value; }


    public bool IsDrawGizmos = false;

    public virtual void LoadComponent()
    {
        _AIEye = GetComponent<AIEyeBase>();
        health = GetComponent<Health>();
        //_SoundCharacterIA = GetComponent<SoundCharacter>();
    }


    public virtual void LookToEnemy()
    {
        if (_AIEye.ViewEnemy != null)
        {
            Vector3 dir = (_AIEye.ViewEnemy.transform.position - transform.position).normalized;
            Quaternion rotY = Quaternion.LookRotation(dir, Vector3.up);
            rotY.x = 0;
            rotY.z = 0;
            transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, rotY, Time.deltaTime * 30);
        }

    }


    public virtual void LookToEnemy(Vector3 pos)
    {
        Vector3 dir = (pos - transform.position).normalized;
        Quaternion rotY = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, rotY, Time.deltaTime * 30);

    }

    public virtual void LookToPosition(Vector3 position)
    {

    }
    public virtual void LookToEnemy(float speed)
    {

    }
}
