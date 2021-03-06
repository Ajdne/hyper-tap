using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game States
public enum GameState { INTRO, MAIN_MENU, GAME }

public delegate void OnStateChangeHandler();

public class GameManager : MonoBehaviour {
    protected GameManager() {}
    private static GameManager instance = null;
    public event OnStateChangeHandler OnStateChange;
    public  GameState gameState { get; private set; }   // a getter for current Game State

    public static GameManager Instance
    {
        get {
            if (GameManager.instance == null){
                //DoNotDestroyOnLoad(GameManager.instance);      //PROBLEM SA OVIME
                //Debug.Log("Get!");
                GameManager.instance = new GameManager();
            }
            return GameManager.instance;
        }
    }

    public void SetGameState(GameState state){
        this.gameState = state;
        OnStateChange();
    }

    public void OnApplicationQuit(){
        GameManager.instance = null;
    }

}
