using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTest : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public GameObject spawnElement;
    void OnMouseDown() {

        
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);    // A

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        // IZBACITI DRAG ZA CANVAS COLIDER
        //STAVITI SPAWN NA KLIK
        
    }

    void OnMouseDrag() {
        Vector3 cursorScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);  // A
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint) + offset;
        transform.position = cursorPosition;

        Instantiate(spawnElement, new Vector3 (cursorPosition.x, cursorPosition.y, cursorPosition.z), Quaternion.identity);
    }


}
