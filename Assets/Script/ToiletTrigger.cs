using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public PlayerMovement player;
    bool close = true;

    // Update is called once per frame
    public void TriggerToilet()
    {
        // animator.SetBool("IsOpen", true);
        if (close)
        {
            animator.Play("Toilet_Open");
            close = false;
            PlayerMovement.finishToilet = true;

            // boxCollider.size = new Vector2(0.24f, 1f);
            // boxCollider.offset = new Vector2(-0.04f, 0.5f);
            return;
        }


    }
}
