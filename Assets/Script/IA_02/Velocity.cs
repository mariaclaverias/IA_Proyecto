using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    private Vector3 startPos;
    private float startTime;

    private Vector3 velocity;

    private Rigidbody rb;

    void Start()
    {
        startTime = Time.deltaTime;

        rb = GetComponent<Rigidbody>();
        startPos = rb.transform.position;
    }

    void Update()
    {
        Vector3 d = rb.transform.position - startPos;
        startPos = rb.transform.position;

        float t = Time.deltaTime - startTime;
        startTime = Time.deltaTime;

        velocity = d / Time.deltaTime;

        Debug.Log("velocidad RB: " + rb.velocity.magnitude + "   velocidad: " + velocity.magnitude);
    }
}
