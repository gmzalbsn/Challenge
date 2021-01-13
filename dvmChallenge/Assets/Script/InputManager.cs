using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    CharacterMovement characterMovement;

    private void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            characterMovement.forward = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            characterMovement.forward = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            characterMovement.backward = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            characterMovement.backward = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            characterMovement.right = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            characterMovement.right = false;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            characterMovement.left = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            characterMovement.left = false;
        }
    }
}
