using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTask : InteractiveObject
{
    [Header("Door")]
    public string levelName;
    public void Door()
    {
        Application.LoadLevel(levelName);
    }
    public override void ExecuteTask()
    {
        Door();
    }
}
