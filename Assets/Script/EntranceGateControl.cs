using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceGateControl : MonoBehaviour
{
    public Dialogue dialogue;
    public InventoryItem_Key KeycardObj;
    public bool keycard;
    public void trigger()
    {
        if (FindObjectOfType<GameManager>().hasPeed == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (keycard)
        {
            FindObjectOfType<GameManager>().EndGood();
        }
        else
        {
            FindObjectOfType<GameManager>().EndTrapped();
        }
        
    }
}
