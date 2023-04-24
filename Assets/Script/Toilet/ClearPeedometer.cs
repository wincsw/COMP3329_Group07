using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearPeedometer : MonoBehaviour
{
    void OnEnable()
    {
        FindObjectOfType<ProgressBar>().ClearValue();
    }
}
