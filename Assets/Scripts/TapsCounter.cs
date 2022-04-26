using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TapsCounter : MonoBehaviour
{
    public TextMeshProUGUI tapsText;    
    public int taps = 0;    

    void Start() {
        //spawnCanvas = GameObject.Find("SpawnCanvas");
        //RayCastTest rayCastScript = spawnCanvas.GetComponent<RayCastTest>();

        //rayCastScript = spawnCanvas.GetComponent<RayCastTest>();

        tapsText.text = "TAPS: 0"; //+ taps.ToString();
    }

    
    public void AddTap() {
        taps += 1;
        tapsText.text = "TAPS: " + taps.ToString();
    }
    

    void Update() {
        //tapsText.text = "TAPS" + rayCastScript.taps.ToString();
    }
}
