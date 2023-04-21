using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    // Start is called before the first frame update
    public InventoryItem_Key inventoryItem;
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
        if (InventoryItem_Key.collected == false)
        {
            Debug.Log("Collected Key");
            InventoryItem_Key.collected = true;
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Key already collected");
        }

    }
}
