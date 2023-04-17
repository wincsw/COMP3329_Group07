using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem_Soap : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isBeaker;
    public bool isSink;
    public bool isOil;
    public bool isLye;
    public static bool hvBeaker;
    public SoapMake soapItems;
    // can hv other trigger
    public void TriggerPickUp()
    {
        if (isBeaker)
        {
            CollectItem_Soap.hvBeaker = true;
            Destroy(gameObject);
        }
        else if (isSink && hvBeaker)
        {
            soapItems.water = true;
        }
        else if (isOil)
        {
            soapItems.oil = true;
            Destroy(gameObject);
        }
        else if (isLye)
        {
            soapItems.lye = true;
            Destroy(gameObject);
        }

    }
}
