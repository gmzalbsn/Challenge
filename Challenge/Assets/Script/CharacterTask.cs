using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTask : InteractiveObject
{
    [Header("OtherCharacter")]
    public int animNumber=0;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void AnimController()
    {
        if (animNumber == 4)
        {
            animNumber = 0;
        }
        animator.SetInteger("animNumber", animNumber);
        animNumber++;
    }
    public override void ExecuteTask()
    {
        AnimController();
    }

}
