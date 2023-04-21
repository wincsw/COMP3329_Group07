using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectToiletPaper : MonoBehaviour
{
    // Start is called before the first frame update
    public InventoryItem_ToiletPaper inventoryItem;
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
        Debug.Log("Collected Toilet Paper");
        InventoryItem_ToiletPaper.collected = true;
        Destroy(gameObject);
    }
}
