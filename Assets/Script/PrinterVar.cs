using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterVar : MonoBehaviour
{
    public static bool printedWeapon = false;
    public GameObject PrinterAudio;

    public void TriggerPriner()
    {
        if (!PrinterVar.printedWeapon)
        {
            PrinterVar.printedWeapon = true;
            PrinterAudio.GetComponent<AudioTrigger>().TriggerAudio();
        }
    }
}
