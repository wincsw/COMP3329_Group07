using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerExitLevel : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = true;
    [SerializeField]
    public SceneInfo sceneInfo;

    public void OnTriggerEnter2D(Collider2D player)
    {
        sceneInfo.isNextScene = isNextScene;
        if (SceneManager.GetActiveScene().name == "Corridor")
        {
            sceneInfo.lastPosition.x = GameObject.FindGameObjectWithTag("Player").transform.position.x - 0.5f;
            sceneInfo.lastPosition.y = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        }
        Debug.Log("Entering " + sceneName);
        sceneInfo.lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}