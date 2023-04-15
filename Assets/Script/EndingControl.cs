using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingControl : MonoBehaviour
{
    public Dialogue dialogue;
    public EndingDialogueManager endingDialogueManager;

    // Start is called before the first frame update
    void Start()
    {

        endingDialogueManager.StartDialogue(dialogue);
        // Destroy(GameObject.FindGameObjectWithTag("GameMusic"));
    }

    public void RestartGame()
    {
        Debug.Log("Restarting game");
        FindObjectOfType<GameManager>().Restart();
    }
}
