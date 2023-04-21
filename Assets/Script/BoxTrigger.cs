using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public int shakeTimes;
    public ShakeCamera shakeCamera;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        shakeTimes = 0;
    }

    public void TriggerBox()
    {
        if (shakeTimes < 3)
        {
            StartCoroutine(shakeCamera.Shake(.09f, .4f));
            shakeTimes++;
        }
        if (shakeTimes == 3)
        {
            animator.Play("dropPlunger");
        }
    }

}
