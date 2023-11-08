using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerIA : MonoBehaviour
{
    public List<MoveToPointState> vehicles = new List<MoveToPointState>();
    public LayerMask layerFloor;
    public Transform cursor;
    Vector3 Target;

    void Start()
    {

    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit, 10000, layerFloor))
        //    {
        //        if (hit.point != Target)
        //        {
        //            Target = hit.point;
        //            cursor.position = Target;
        //            foreach (var item in vehicles)
        //            {
        //                ((MoveToPointState)item).Target = Target;
        //            }
        //        }

        //    }

        //}

    }
}
