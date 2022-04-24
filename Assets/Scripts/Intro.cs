using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    GameManager GM;

    void Awake ()
    {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;

        Debug.Log("Current game state when Awakes: " + GM.gameState);
    }

    void Start ()
    {
        Debug.Log("Current game state when Starts: " + GM.gameState);
    }

    public void HandleOnStateChange ()
    {
        GM.SetGameState(GameState.MAIN_MENU);
        Debug.Log("Handling state change to: " + GM.gameState);
        Invoke("LoadLevel", 3f);    // load level after 3 seconds
    }

    public void LoadLevel()
    {
        Application.LoadLevel("MenuScene");
    }
}
