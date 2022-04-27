using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{   
    Ray ray;
    RaycastHit hit;
    public GameObject bronzeCube;
    private TapsCounter tapsCounterScript;
    GameObject tapsCanvas;

    void Start() {
        
    }
    void Update() {
        ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        if (Physics.Raycast (ray, out hit)) {   // if the ray hits something, store data in hit variable

            if (hit.collider.tag == "Spawn Canvas") { // if it hits spawn canvas collider

                if (Input.GetMouseButtonDown(0)) {
                    Instantiate(bronzeCube, hit.point + new Vector3(0, 0, -0.5f), Quaternion.identity);
                    //Debug.Log (hit.point);
                    tapsCounterScript.AddTap();

                    Debug.Log(tapsCounterScript.taps);
                }
            }
        }
    }
    /*
    public void AddTap() {
        taps += 1;
    }
    */
}
