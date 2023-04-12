using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;

    void Awake()
    {
        Instance = this;

    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}

public enum GameState
{
    KeyCollect,
    PlungerCollect,
    SoapCollect,
    ToiletPaperCollect,
    KeyCardCollect,
    PlayLoc_Corridor



}