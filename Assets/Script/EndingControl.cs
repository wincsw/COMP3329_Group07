using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingControl : MonoBehaviour
{
    public Dialogue dialogue;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<EndingDialogueManager>().StartDialogue(dialogue);
        Destroy(GameObject.FindGameObjectWithTag("GameMusic"));
    }

    public void RestartGame()
    {
        Debug.Log("Restarting game");
        FindObjectOfType<GameManager>().Restart();
    }
}
