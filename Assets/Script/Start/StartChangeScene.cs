using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChangeScene : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = false;

    void OnEnable()
    {
        Debug.Log("Entering DreamChamber");
        SceneManager.LoadScene("DreamChamber");
    }
}
