using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem_Soap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject item;
    public bool collected;
    // can hv other trigger
    public void TriggerPickUp()
    {
        collected = true;
        if (item.name != "i-Sink")
        {
            Destroy(item);
        }

    }
}
