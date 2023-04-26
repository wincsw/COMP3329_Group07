using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PositionController : MonoBehaviour
{
    public SceneInfo sceneInfo;
    
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (SceneManager.GetActiveScene().name == "Corridor")
        {
            if (sceneInfo.lastScene == "Entrance")
            {
                sceneInfo.lastPosition.x -= 0.5f;
            }
            if (sceneInfo.lastScene == "3DPrinterArea")
            {
                sceneInfo.lastPosition.y -= 0.5f;
            }
            player.transform.position = new Vector2(sceneInfo.lastPosition.x, sceneInfo.lastPosition.y);
        }
        else if (SceneManager.GetActiveScene().name == "Entrance")
        {
            if (sceneInfo.lastScene == "Corridor")
            {
                float positionY = -0.5668268f - (-30.01865f - sceneInfo.lastPosition.y)/6.47636f*3.1004322f;
                player.transform.position = new Vector2(player.transform.position.x, positionY);
            }
        }
        
    }
}
