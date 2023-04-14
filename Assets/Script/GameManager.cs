using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    
    public void Awake()
    {
        GameObject[] gameManager = GameObject.FindGameObjectsWithTag("GameController");
        if (gameManager.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public void EndPeed()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            SceneManager.LoadScene("EndingPeed");
        }
    }

    public void EndGood()
    {

    }

    public void EndTrapped()
    {

    }

    public void EndCaught()
    {

    }

    public void Restart()
    {
        Debug.Log("Restart");
        // SceneManager.LoadScene("DreamChamber");
    }
}
