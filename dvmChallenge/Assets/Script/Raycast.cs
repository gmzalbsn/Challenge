using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private Camera camera;
    public CharacterMovement character;

    public void Start()
    {
        camera = GetComponent<Camera>();
        character = FindObjectOfType<CharacterMovement>();
    }
    public void Update()
    {
        if(character.RaycastActive)
        RaycastObject();
    }
    public void RaycastObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                character.TriggerObject.GetComponent<InteractiveObject>().ExecuteTask();     
            }
        }
    }
}
