using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    public SceneInfo sceneInfo;
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector2(sceneInfo.lastPosition.x, sceneInfo.lastPosition.y);
    }
}
