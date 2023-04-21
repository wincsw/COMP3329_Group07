using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaceKeyCard : MonoBehaviour
{

    public List<GameObject> floors = new List<GameObject>();
    public GameObject keyCard;
    void Start()
    {
        int randomFloor = Random.Range(0, floors.Count);
        GameObject floor = floors[randomFloor];
        MeshCollider c = floor.GetComponent<MeshCollider>();

        float screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
        float screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
        keyCard.transform.position = new Vector3(screenX, screenY, 0);



    }




}
