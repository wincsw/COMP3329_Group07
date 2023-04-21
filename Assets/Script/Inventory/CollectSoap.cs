using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSoap : MonoBehaviour
{
    // Start is called before the first frame update
    public InventoryItem_Soap inventoryItem;
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
        Debug.Log("Collected Soap");
        InventoryItem_Soap.collected = true;
        Destroy(gameObject);
    }
}
