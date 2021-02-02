using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampTask : InteractiveObject
{
    [Header("Lamp")]
    public bool lightToggle;
    public GameObject lampLight;
    public void Lamp()
    {
        lightToggle = !lightToggle;
        lampLight.SetActive(lightToggle);
    }

    public override void ExecuteTask()
    {
        Lamp();
    }
}
