using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPlunger : MonoBehaviour
{
    // Start is called before the first frame update
    public InventoryItem_Plunger inventoryItem;
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
        InventoryItem_Plunger.collected = true;
        Destroy(gameObject);
    }
}
