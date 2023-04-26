using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class StartTrigger : MonoBehaviour
{

    public PlayableDirector playableDirector;

    public AudioSource startMusic;

    float startTime;
    const float  FIRSTWAITTIME = 60f;
    float spawnDuration = 3;
    float lastSpawnTime;
    public GameObject toiletPaper;
    bool pressedStart = false;

    void Start()
    {
        Cursor.visible = false;
        startTime = Time.time + FIRSTWAITTIME;
        lastSpawnTime = startTime;
    }

    void Update()
    {
        if (!pressedStart && Input.GetKeyDown(KeyCode.Space))
        {
            DestroyTPRoll[] tpRolls = FindObjectsOfType<DestroyTPRoll>();
            foreach (DestroyTPRoll tpRoll in tpRolls)
            {
                Destroy(tpRoll.gameObject);
            }
            pressedStart = true;
            Debug.Log("Play intro");
            playableDirector.Play();
            startMusic.Stop();
        }
        if(!pressedStart && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        float now = Time.time;
        // Debug.Log(now);
        if (!pressedStart && (now - startTime > spawnDuration))
        {
            if (now - lastSpawnTime > spawnDuration)
            {   
                Vector2 randomPosition = new Vector2(Random.Range(-8.14f, 8.06f), 5.83f);
                Instantiate(toiletPaper, randomPosition, Quaternion.identity);
                lastSpawnTime = now;
            }
        }
        
    }
}
