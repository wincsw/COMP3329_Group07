using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeycard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inventoryItem;


    // can hv other trigger
    public void TriggerPickUp()
    {
        Debug.Log("Collected Keycard");
        InventoryItem_Keycard.collected = true;
        Destroy(gameObject);
    }
}
