using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{   
    Ray ray;
    RaycastHit hit;
    public TapsCounter tapsCounterObj;
    public CubeScript cubeObj;
    public GameObject silverCube;
    int bronzeCubesNumber = 0;

    // Vector3 averageTransform;
    float averageX;
    float averageY;

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
                    Debug.Log(cubeObj.transform.position);
                }
            }
        }
        GameObject[] bronzeCubes = GameObject.FindGameObjectsWithTag("Bronze Cube");

        if (bronzeCubesNumber % 10 == 0 && bronzeCubesNumber != 0) {
            Debug.Log("Destroy!");
            
            foreach (GameObject cube in bronzeCubes) {
                
                averageX += transform.position.x;
                averageY += transform.position.y;

                Destroy(cube, 1.0f);
            }

            
            Instantiate(silverCube, new Vector3(averageX, averageY, -0.5f), Quaternion.identity);   // spawn a cube on an average position
            Debug.Log(silverCube.transform.position);

            bronzeCubesNumber = 0;  // reset the number of bronze cubes
        }
    }

}
