using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class StartTrigger : MonoBehaviour
{

    public PlayableDirector playableDirector;
    public List<GameObject> textList = new List<GameObject>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Play intro");
            playableDirector.Play();
            for (int i = 0; i < textList.Count; i++)
            {
                Destroy(textList[i]);
            }

        }


    }
}
