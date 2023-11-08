using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steering : MonoBehaviour
{
    public List<GameObject> vehicles;
    public float index;

    public GameObject prefab;

    public float desiredSeparation;

    private void Start()
    {
        InstantiateEnemy();
        Separation(vehicles);
    }

    void Update()
    {
        //InputMouse();
    }

    void InputMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            Debug.Log(raycastHit.point);
            //transform.position = raycastHit.point;
        }
    }

    public void InstantiateEnemy()
    {
        for (int i = 0; i < index; i++)
        {
            GameObject currentVehicle = Instantiate(prefab, transform.position, Quaternion.identity);
            vehicles.Add(currentVehicle);
        }
    }

    public void Separation(List<GameObject> vehicles)
    {
        //float desiredSeparation = r * 2;
        //Vector3 sum = new Vector3();
        //int count = 0;

        foreach (GameObject other in vehicles)
        {
            Vector3 direccion = (other.transform.position - transform.position);
            float d = direccion.magnitude;

            if ((d > 0) && (d < desiredSeparation))
            {
                Vector3 diff = (transform.position - other.transform.position).normalized;
                //sum += sum
            }
        }
    }
}
