using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTask : InteractiveObject
{
    [Header("Board")]
    public float rotateAngle;
    public void Board()
    {
     transform.Rotate(Vector3.forward * rotateAngle);
    }
    public override void ExecuteTask()
    {
        Board();
    }
}
