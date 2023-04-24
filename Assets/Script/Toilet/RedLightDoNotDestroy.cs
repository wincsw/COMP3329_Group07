using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightDoNotDestroy : MonoBehaviour
{
    public AlarmDoNotDestroy alarmDoNotDestroy;
    void Awake()
    {
        this.gameObject.SetActive(true);
        Debug.Log("red light: " + this.isActiveAndEnabled);
        alarmDoNotDestroy.PlayAlarm();
        GameObject[] overlays = GameObject.FindGameObjectsWithTag("Overlay");
        if (overlays.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
