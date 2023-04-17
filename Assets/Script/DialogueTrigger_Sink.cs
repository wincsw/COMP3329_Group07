using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_Sink : MonoBehaviour
{
    public Dialogue haveBeaker;
    public Dialogue noBeaker;

    public bool beaker;

    void Update()
    {
        beaker = CollectItem_Soap.hvBeaker;
    }

    public void TriggerDialogue()
    {


        if (beaker)
        {
            Debug.Log("Dialogue with obj Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(haveBeaker);
        }
        else
        {
            Debug.Log("Dialogue without obj Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(noBeaker);
        }
    }
}
