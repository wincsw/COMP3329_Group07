using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_BreadFish : MonoBehaviour
{
    public Dialogue dialogueWithoutWeapon;
    public Dialogue dialogueWithWeapon;
    public Dialogue dialogueDefeated;
    public bool defeat;
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
        if (defeat)
        {
            Debug.Log("Dialogue defeated Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueDefeated);
        }
        else if (weapon)
        {
            Debug.Log("Dialogue with weapon Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueWithWeapon);
            defeat = GetComponent<FightBreadFish>().defeat;
        }
        else
        {
            Debug.Log("Dialogue withOUT weapon Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueWithoutWeapon);
        }
    }
}
