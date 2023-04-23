using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneInfo", menuName = "Persistance")]
public class SceneInfo : ScriptableObject
{
    public bool isNextScene = true;
    public Vector2 lastPosition;

    public string lastScene;

    void onEnable()
    {
        lastPosition = new Vector2(47.5f, 5f);
    }
}
