using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_Condition : MonoBehaviour
{
    public bool needKey;
    public bool needPlunger;
    public bool needToiletPaper;
    public bool needSoap;
    public bool needKeycard;
    public Dialogue dialogueWithObj;
    public Dialogue dialogueWithoutObj;
    public InventoryItem_Key KeyObj;
    public InventoryItem_Plunger PlungerObj;
    public InventoryItem_ToiletPaper ToiletPaperObj;
    public InventoryItem_Soap SoapObj;
    public InventoryItem_Keycard KeycardObj;
    public bool key;
    public bool plunger;
    public bool toiletPaper;
    public bool soap;
    public bool keycard;


    public void TriggerDialogue()
    {

        // key = KeyObj.GetComponent<InventoryItem>().collected;
        // plunger = PlungerObj.GetComponent<InventoryItem>().collected;
        // toiletPaper = ToiletPaperObj.GetComponent<InventoryItem>().collected;
        // soap = SoapObj.GetComponent<InventoryItem>().collected;
        // keycard = KeycardObj.GetComponent<InventoryItem>().collected;

        key = InventoryItem_Key.collected;
        plunger = InventoryItem_Plunger.collected;
        toiletPaper = InventoryItem_ToiletPaper.collected;
        soap = InventoryItem_Soap.collected;
        keycard = InventoryItem_Keycard.collected;

        Debug.Log("key: " + key);
        Debug.Log("plunger: " + plunger);
        Debug.Log("toiletPaper: " + toiletPaper);
        Debug.Log("soap: " + soap);
        Debug.Log("keycard: " + keycard);

        bool[] needList = { needKey, needPlunger, needToiletPaper, needSoap, needKeycard };
        bool[] hvList = { key, plunger, toiletPaper, soap, keycard };

        bool hvAllObj = true;

        for (int i = 0; i < 5; i++)
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
