using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HighlightPlus;


public abstract class InteractiveObject : MonoBehaviour
{
    
    public HighlightEffect highlightEffect;

    public void ToggleHighlight(bool toggle)
    {
        highlightEffect.highlighted = toggle;
    }
    public abstract void ExecuteTask();
    
}
