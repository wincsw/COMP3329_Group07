using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceGateControl : MonoBehaviour
{
    public Dialogue dialogue;

    public void trigger()
    {
        if (FindObjectOfType<GameManager>().hasPeed == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (InventoryItem_Keycard.collected)
        {
            FindObjectOfType<GameManager>().EndGood();
        }
        else
        {
            FindObjectOfType<GameManager>().EndTrapped();
        }
        
    }
}
