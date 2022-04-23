using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{   
    public float rayDistance = 20f;
    void FixedUpdate() {
        if (Input.GetMouseButtonDown(0)) {      // OVO U NOVU SKRIPTU

            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast (ray, out hit, rayDistance)) {

                 //draw invisible ray cast/vector
                 Debug.DrawLine (ray.origin, hit.point, Color.red);
                 //log hit area to the console
                 Debug.Log(hit.point);                                   
             }    
        }
    }
}
