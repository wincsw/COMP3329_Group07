using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : CollidableObject
{
    public bool z_Interacted = false;
    public bool hasDialogue;
    public DialogueTrigger dialogueTrigger;

    protected override void OnCollided(GameObject collidedObject)
    {
        if (Input.GetKeyDown("space"))
        {
            OnInteract();
        }
    }
    
    protected void OnInteract()
    {
        if (!z_Interacted)
        {
            z_Interacted = true;
            Debug.Log("INTERACT WITH " + name);
            if (hasDialogue)
            {
                dialogueTrigger.TriggerDialogue();
            }
        }
        
    }
}
