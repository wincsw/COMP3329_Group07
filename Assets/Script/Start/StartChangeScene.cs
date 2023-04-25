using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChangeScene : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = false;

    public SceneInfo sceneInfo;

    void OnEnable()
    {

        Debug.Log("Entering DreamChamber");
        SceneManager.LoadScene("DreamChamber");
        sceneInfo.lastPosition = new Vector2(47.5f, 5f);

    }
}
