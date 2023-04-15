using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    bool close = true;

    // Update is called once per frame
    public void OpenToilet()
    {
        if (close)
        {
            animator.Play("Toilet_Open");
            close = false;
            return;
        }
    }

    public void CloseToilet()
    {
        if (!close)
        {
            animator.Play("Toilet_Close");
            close = true;
            return;
        }
    }
}
