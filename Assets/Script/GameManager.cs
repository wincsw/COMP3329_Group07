using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public bool hasPeed = false; 

    [SerializeField]
    public SceneInfo sceneInfo;
    
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
            Debug.Log("GAME OVER: PEED END");
            SceneManager.LoadScene("EndingPeed");
        }
    }

    public void EndGood()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER: GOOD END");
            SceneManager.LoadScene("EndingGood");
        }
    }

    public void EndTrapped()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER: TRAPPED END");
            SceneManager.LoadScene("EndingTrapped");
        }
    }

    public void EndCaught()
    {

    }

    public void Restart()
    {
        Debug.Log("Restart");
        GameObject[] musicObjs = GameObject.FindGameObjectsWithTag("GameMusic");
        foreach (GameObject musicObj in musicObjs)
        {
            Destroy(musicObj);
        }
        hasPeed = false;
        gameHasEnded = false;
        FindObjectOfType<ProgressBar>().ResetValue();
        sceneInfo.lastPosition = new Vector2(46.5f, 5);
        SceneManager.LoadScene("DreamChamber");
    }
}
