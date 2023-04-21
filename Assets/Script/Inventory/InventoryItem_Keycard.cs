using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem_Keycard : MonoBehaviour
{
    // Start is called before the first frame update
    Material original_Material;
    public Material new_Material;
    public static bool collected = false;
    public string itemName;


    void Start()
    {
        original_Material = GetComponent<Renderer>().material;
        GetComponent<Renderer>().material = new_Material;

    }

    // Update is called once per frame
    void Update()
    {
        if (collected)
        {
            GetComponent<Renderer>().material = original_Material;
        }

    }
}
