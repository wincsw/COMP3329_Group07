using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBreadFish : MonoBehaviour
{
    public bool defeat;
    public bool weapon;
    public Dialogue dialogue;

    public void DefeatBreadFish()
    {
        weapon = PrinterVar.printedWeapon;

        if (weapon)
        {
            defeat = true;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }

}
