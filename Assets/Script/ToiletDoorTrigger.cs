using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public bool key = false;
    public bool plunger = false;
    public bool toiletPaper = false;
    public bool soap = false;
    bool close = true;
    public BoxCollider2D boxCollider;
    void Start()
    {

        // animator.SetBool("IsOpen", false);

    }

    // Update is called once per frame
    public void TriggerToiletDoor()
    {
        if (key && plunger && toiletPaper && soap)
        {
            // animator.SetBool("IsOpen", true);
            if (close)
            {
                animator.Play("ToiletDoor_Open");
                close = false;
                boxCollider.size = new Vector2(0.16f, 1.18f);
                boxCollider.offset = new Vector2(-0.08f, 0.6f);
                return;
            }
            else
            {
                animator.Play("ToiletDoor_Close");
                close = true;
                boxCollider.size = new Vector2(0.8f, 1.18f);
                boxCollider.offset = new Vector2(-0.4f, 0f);
                return;
            }

        }

    }
}
