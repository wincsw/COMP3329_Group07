using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionController : MonoBehaviour
{
    public SceneInfo sceneInfo;
    // Start is called before the first frame update
    void Start()
    {
        if (sceneInfo.lastScene == "Start")
        {
            Debug.Log("PlayerPositionController.Start()");
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector2(1.78f, -3.03f);
            sceneInfo.lastScene = "DreamChamber";
        }
    }
}
