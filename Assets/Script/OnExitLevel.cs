using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnExitLevel : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = true;
    [SerializeField]
    public SceneInfo sceneInfo;

    public void EnterScene()
    {
        sceneInfo.isNextScene = isNextScene;
        if (SceneManager.GetActiveScene().name == "Corridor")
        {
            sceneInfo.lastPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        }
        Debug.Log("Entering " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
