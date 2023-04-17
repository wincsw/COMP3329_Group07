using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_Lab : MonoBehaviour
{
    public bool needLye;
    public bool needOil;
    public bool needBeaker;
    public bool needWater;
    public Dialogue dialogueWithObj;
    public Dialogue dialogueWithoutObj;
    public GameObject Lye;
    public GameObject Oil;
    public GameObject Sink;
    public GameObject Beaker;

    public bool lye;
    public bool oil;
    public bool beaker;
    public bool water;

    public void TriggerDialogue()
    {

        beaker = Beaker.GetComponent<CollectItem_Soap>().collected;
        oil = Oil.GetComponent<CollectItem_Soap>().collected;
        lye = Lye.GetComponent<CollectItem_Soap>().collected;
        water = Sink.GetComponent<CollectItem_Soap>().collected;

        // key = InventoryItem_Key.collected;
        // plunger = InventoryItem_Plunger.collected;
        // toiletPaper = InventoryItem_ToiletPaper.collected;
        // soap = InventoryItem_Soap.collected;
        // keycard = InventoryItem_Keycard.collected;



        bool[] needList = { needBeaker, needLye, needOil, needWater };
        bool[] hvList = { beaker, lye, oil, water };

        bool hvAllObj = true;

        for (int i = 0; i < 4; i++)
        {
            if (needList[i] == true && hvList[i] == false)
            {
                hvAllObj = false;
                break;
            }
        }

        if (hvAllObj)
        {
            Debug.Log("Dialogue with obj Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueWithObj);
        }
        else
        {
            Debug.Log("Dialogue without obj Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueWithoutObj);
        }
    }
}
