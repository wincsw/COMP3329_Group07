using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame(string endingScene)
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(endingScene);
            // Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("DreamChamber");
    }
}
