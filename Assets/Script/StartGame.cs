using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string sceneName;
    public SceneInfo sceneInfo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Entering " + sceneName);
            SceneManager.LoadScene("DreamChamber");
        }


    }
}
