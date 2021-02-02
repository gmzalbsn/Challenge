using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverTask : InteractiveObject
{
    [Header("Cover")]
    public bool animBool;
    public Animator CoverAnimator;
    public CharacterInstantiate characterInstantiate;
    public void Start()
    {
        characterInstantiate = FindObjectOfType<CharacterInstantiate>();
    }
    public void Cover()
    {
        characterInstantiate.playerInstantiate.GetComponent<CharacterMovement>().TriggerObject.GetComponent<InteractiveObject>().ToggleHighlight(false);
        animBool = !animBool;
        CoverAnimator.SetBool("Coverbool", animBool);
    }
    public override void ExecuteTask()
    {
        Cover();
    }
}
