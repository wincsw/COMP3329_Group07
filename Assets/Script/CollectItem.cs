using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    // Start is called before the first frame update
    public InventoryItem inventoryItem;
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
        InventoryItem.collected = true;
        Destroy(gameObject);
    }
}
