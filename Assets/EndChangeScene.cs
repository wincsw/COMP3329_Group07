using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndChangeScene : MonoBehaviour
{
    void OnEnable()
    {
        Debug.Log("Should change scene");
        FindObjectOfType<GameManager>().Restart();
    }
}
