using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inventory_item;
    InventoryItem item_script;
    void Start()
    {
        // get inventory item's script
        item_script = inventory_item.GetComponent<InventoryItem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // can hv other trigger
    void OnMouseDown()
    {
        item_script.collected = true;
    }
}
