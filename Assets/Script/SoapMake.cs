using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapItem : MonoBehaviour
{
    public bool lye = false;
    public bool oil = false;
    public bool beaker = false;
    public bool water = false;
    public GameObject Lye;
    public GameObject Oil;
    public GameObject Sink;
    public GameObject Beaker;
    public bool soapMade = false;
    // Start is called before the first frame update
    public void IsSoapMade()
    {
        if (!soapMade && lye && oil && beaker && water)
        {
            InventoryItem_Soap.collected = true;
        }
    }
}
