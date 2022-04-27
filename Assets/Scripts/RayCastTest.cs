using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{   
    Ray ray;
    RaycastHit hit;
    public TapsCounter tapsCounterObj;
    public CubeScript cubeObj;
    int bronzeCubesNumber = 0;


    void Start() {
        cubeObj.cubeNumber = 0; // reset cube number
    }

    void Update() {
        ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        if (Physics.Raycast (ray, out hit)) {   // if the ray hits something, store data in hit variable

            if (hit.collider.tag == "Spawn Canvas") { // if it hits spawn canvas collider

                if (Input.GetMouseButtonDown(0)) {

                    cubeObj.cubeNumber += 1;
                    Instantiate(cubeObj, hit.point + new Vector3(0, 0, -0.5f), Quaternion.identity);
                    bronzeCubesNumber += 1;

                    tapsCounterObj.AddTap();

                    Debug.Log(cubeObj.cubeNumber);
                }
            }
        }
        GameObject[] bronzeCubes = GameObject.FindGameObjectsWithTag("Bronze Cube");

        if (bronzeCubesNumber % 10 == 0 && bronzeCubesNumber != 0) {
            Debug.Log("Destroy!");
            
            foreach (GameObject cube in bronzeCubes) {
                Destroy(cube, 1.0f);
            }
            bronzeCubesNumber = 0;
        }
    }

}
