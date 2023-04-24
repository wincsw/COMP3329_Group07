using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRedOverlayActive : MonoBehaviour
{
    public GameObject gameObj;
    // Start is called before the first frame update
    void OnEnable()
    {
        gameObj.SetActive(true);
    }
}
