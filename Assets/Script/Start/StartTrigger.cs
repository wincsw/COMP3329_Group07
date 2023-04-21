using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class StartTrigger : MonoBehaviour
{

    public PlayableDirector playableDirector;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Play intro");
            playableDirector.Play();

        }


    }
}
