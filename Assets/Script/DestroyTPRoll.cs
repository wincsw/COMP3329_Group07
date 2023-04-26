using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTPRoll : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject.transform.position.y < -6.09)
        {
            Destroy(this.gameObject);
        } 
    }
}
