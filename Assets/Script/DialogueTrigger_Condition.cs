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
    public GameObject KeyObj;
    public GameObject PlungerObj;
    public GameObject ToiletPaperObj;
    public GameObject SoapObj;
    public GameObject KeycardObj;
    public bool key;
    public bool plunger;
    public bool toiletPaper;
    public bool soap;
    public bool keycard;


    public void TriggerDialogue()
    {

        key = KeyObj.GetComponent<InventoryItem>().collected;
        plunger = PlungerObj.GetComponent<InventoryItem>().collected;
        toiletPaper = ToiletPaperObj.GetComponent<InventoryItem>().collected;
        soap = SoapObj.GetComponent<InventoryItem>().collected;
        keycard = KeycardObj.GetComponent<InventoryItem>().collected;

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
            Debug.Log("Dialogue Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueWithObj);
        }
        else
        {
            Debug.Log("Dialogue Triggered");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueWithoutObj);
        }
    }
}
