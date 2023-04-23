using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaceKeyCard : MonoBehaviour
{

    public List<GameObject> floors = new List<GameObject>();
    public static bool placed = false;
    public static float screenX;
    public static float screenY;
    void Start()
    {
        if (!placed && !InventoryItem_Keycard.collected)
        {
            PlaceCard();
        }
        else if (InventoryItem_Keycard.collected)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.transform.position = new Vector3(screenX, screenY, 0);
        }
    }


    public void PlaceCard()
    {
        int randomFloor = Random.Range(0, floors.Count);
        GameObject floor = floors[randomFloor];
        MeshCollider c = floor.GetComponent<MeshCollider>();

        screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
        screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
        gameObject.transform.position = new Vector3(screenX, screenY, 0);

        placed = true;
    }




}
