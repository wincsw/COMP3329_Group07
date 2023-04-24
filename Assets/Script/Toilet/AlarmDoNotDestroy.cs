using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmDoNotDestroy : MonoBehaviour
{
    public AudioTrigger audioTrigger;
    // Start is called before the first frame update
    public void PlayAlarm()
    {
        // Debug.Log("finish toilet: " + ToiletTrigger.finishToilet);
        if (ToiletTrigger.finishToilet)
        {
            audioTrigger.gameObject.SetActive(true);
            audioTrigger.TriggerAudio();
            GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Alarm");
            if (musicObj.Length > 1)
            {
                Destroy(this.gameObject);
            }
            DontDestroyOnLoad(this.gameObject);
        }

    }
}
