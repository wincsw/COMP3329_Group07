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

    public void DestroyMusic()
    {
        GameObject[] alarmObj = GameObject.FindGameObjectsWithTag("Alarm");
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        GameObject[] overlayObj = GameObject.FindGameObjectsWithTag("Overlay");
        foreach (GameObject alarm in alarmObj)
        {
            Destroy(alarm);
        }
        foreach (GameObject music in musicObj)
        {
            Destroy(music);
        }
        foreach (GameObject overlay in overlayObj)
        {
            Destroy(overlay);
        }
        
    }
    public void EndPeed()
    {
        if (!gameHasEnded)
        {
            DestroyMusic();
            gameHasEnded = true;
            Debug.Log("GAME OVER: PEED END");
            SceneManager.LoadScene("EndingPeed");
        }
    }

    public void EndGood()
    {
        if (!gameHasEnded)
        {
            DestroyMusic();
            gameHasEnded = true;
            Debug.Log("GAME OVER: GOOD END");
            SceneManager.LoadScene("EndingGood");
        }
    }

    public void EndTrapped()
    {
        if (!gameHasEnded)
        {
            DestroyMusic();
            gameHasEnded = true;
            Debug.Log("GAME OVER: TRAPPED END");
            SceneManager.LoadScene("EndingTrapped");
        }
    }

    public void EndCaught()
    {
        if (!gameHasEnded)
        {
            DestroyMusic();
            gameHasEnded = true;
            Debug.Log("GAME OVER: TRAPPED END");
            SceneManager.LoadScene("EndingCaught");
        }
    }

    public void Restart()
    {
        Debug.Log("Restart");
        DestroyMusic();
        InventoryItem_Soap.collected = false;
        InventoryItem_ToiletPaper.collected = false;
        InventoryItem_Key.collected = false;
        InventoryItem_Plunger.collected = false;
        InventoryItem_Keycard.collected = false;
        hasPeed = false;
        gameHasEnded = false;
        // FindObjectOfType<ProgressBar>().ResetValue();
        sceneInfo.lastPosition = new Vector2(46.5f, 5);
        sceneInfo.lastScene = "Start";
        SceneManager.LoadScene("Start");
    }
}
