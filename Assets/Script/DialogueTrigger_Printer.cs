using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_Printer : MonoBehaviour
{
    public FightBreadFish breadFish;
    public Dialogue dialogueWithObj;
    public Dialogue dialogueWithoutObj;
    public bool weapon;


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


        // if (key && plunger && toiletPaper && soap)
        if (weapon)
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
