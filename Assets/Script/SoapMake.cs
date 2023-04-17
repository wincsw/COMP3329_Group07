using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapMake : MonoBehaviour
{
    public bool lye = false;
    public bool oil = false;
    public bool water = false;
    public Dialogue dialogue;
    // Start is called before the first frame update
    public void IsSoapMade()
    {
        if (lye && oil && water)
        {
            InventoryItem_Soap.collected = true;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        }
    }
}
