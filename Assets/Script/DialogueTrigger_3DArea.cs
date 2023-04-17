using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_3DArea : MonoBehaviour
{
    public bool needWeapon = true;
    public bool needDefeat;
    public FightBreadFish breadFish;
    public Dialogue dialogueWithObj;
    public Dialogue dialogueWithoutObj;
    public bool weapon;
    public bool defeat;


    public void TriggerDialogue()
    {

        // key = KeyObj.GetComponent<InventoryItem>().collected;
        // plunger = PlungerObj.GetComponent<InventoryItem>().collected;
        // toiletPaper = ToiletPaperObj.GetComponent<InventoryItem>().collected;
        // soap = SoapObj.GetComponent<InventoryItem>().collected;
        // keycard = KeycardObj.GetComponent<InventoryItem>().collected;

        // key = InventoryItem_Key.collected;
        // plunger = InventoryItem_Plunger.collected;
        // toiletPaper = InventoryItem_ToiletPaper.collected;
        // soap = InventoryItem_Soap.collected;
        // keycard = InventoryItem_Keycard.collected;
        weapon = PrinterVar.printedWeapon;
        defeat = breadFish.defeat;

        bool[] needList = { needWeapon, needWeapon };
        bool[] hvList = { weapon, defeat };

        bool hvAllObj = true;

        for (int i = 0; i < 2; i++)
        {
            if (needList[i] == true && hvList[i] == false)
            {
                hvAllObj = false;
                break;
            }
        }

        // if (key && plunger && toiletPaper && soap)
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
