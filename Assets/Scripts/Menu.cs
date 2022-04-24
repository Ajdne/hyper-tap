using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    GameManager GM;

    void Awake () {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    public void HandleOnStateChange ()
    {
        Debug.Log("OnStateChange!");
    }


    public void OnGUI(){
        //menu layout
        GUI.BeginGroup (new Rect (0, 0, Screen.width, Screen.height));
        GUI.Box (new Rect (0, 0, Screen.width, Screen.height), "Menu");
        if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 40, 80, 30), "Start")) {
            StartGame();
        }
        if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 120, 80, 30), "Quit")) {
            Quit();
        }
        GUI.EndGroup();
    }                   
                        /************************
                        MOZDA OVO ODRADITI PREKO CANVASA
                        *************************/

    public void StartGame(){
        //start game scene
        GM.SetGameState(GameState.GAME);
        Debug.Log(GM.gameState);
    }

    public void Quit(){
        Debug.Log("Quit!");
        Application.Quit();
    }
}
