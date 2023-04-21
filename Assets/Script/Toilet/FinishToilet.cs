using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class FinishToilet : MonoBehaviour
{

    public PlayableDirector playableDirector;
    public GameObject toiletDoor;
    public PlayerMovement player;

    // Start is called before the first frame update
    public void TriggerFinishToilet()
    {
        PlayerMovement.finishToilet = true;
        playableDirector.Play();
        toiletDoor.GetComponent<BoxCollider2D>().enabled = false;
        return;
    }


}
