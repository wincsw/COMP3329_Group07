using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    public InventoryItem_Key KeyObj;
    public InventoryItem_Plunger PlungerObj;
    public InventoryItem_ToiletPaper ToiletPaperObj;
    public InventoryItem_Soap SoapObj;

    public bool key;
    public bool plunger;
    public bool toiletPaper;
    public bool soap;
    bool close = true;
    public BoxCollider2D boxCollider;

    // Update is called once per frame
    public void TriggerToiletDoor()
    {
        // key = KeyObj.GetComponent<InventoryItem>().collected;
        // plunger = PlungerObj.GetComponent<InventoryItem>().collected;
        // toiletPaper = ToiletPaperObj.GetComponent<InventoryItem>().collected;
        // soap = SoapObj.GetComponent<InventoryItem>().collected;

        // key = InventoryItem_Key.collected;
        // plunger = InventoryItem_Plunger.collected;
        // toiletPaper = InventoryItem_ToiletPaper.collected;
        // soap = InventoryItem_Soap.collected;

        Debug.Log("key: " + key);
        Debug.Log("plunger: " + plunger);
        Debug.Log("toiletPaper: " + toiletPaper);
        Debug.Log("soap: " + soap);

        if (key && plunger && toiletPaper && soap)
        {
            // animator.SetBool("IsOpen", true);
            if (close)
            {
                animator.Play("ToiletDoor_Open");
                close = false;
                boxCollider.size = new Vector2(0.24f, 1f);
                boxCollider.offset = new Vector2(-0.04f, 0.5f);
                return;
            }
            else
            {
                animator.Play("ToiletDoor_Close");
                close = true;
                boxCollider.size = new Vector2(0.8f, 0.8f);
                boxCollider.offset = new Vector2(-0.4f, -0.24f);
                return;
            }

        }

    }
}
