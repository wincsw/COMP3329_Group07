using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeycard : MonoBehaviour
{
    // Start is called before the first frame update
    public InventoryItem_Keycard inventoryItem;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // can hv other trigger
    public void TriggerPickUp()
    {
        Debug.Log("Collected Keycard");
        InventoryItem_Keycard.collected = true;
        Destroy(gameObject);
    }
}