using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class StartTrigger : MonoBehaviour
{

    public PlayableDirector playableDirector;
    public List<GameObject> textList = new List<GameObject>();

    public GameObject canvas;
    public AudioSource startMusic;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Play intro");
            playableDirector.Play();
            startMusic.Stop();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
