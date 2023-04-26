using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator;
    void OnEnable()
    {
        Debug.Log("play animation");
        animator.SetFloat("Vertical", -1);
        animator.Play("player_shocked");
    }
}
