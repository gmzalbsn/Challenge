using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Character")]
    public float moveSpeed;
    public float rotateSpeed;
    public bool forward;
    public bool backward;
    public bool right;
    public bool left;
    public bool RaycastActive=false;
    public Collider TriggerObject;
    public Raycast raycast;
    public Collider ExitOtherObject;
    TrashTask trashTask;
    Rigidbody myBody;
    Animator myAnimator;
    



    private void Start()
    {
        myBody = GetComponent<Rigidbody>();
        myAnimator = GetComponent<Animator>();
        trashTask = FindObjectOfType<TrashTask>();
    }

    private void Update()
    {
        myAnimator.SetFloat("Speed", myBody.velocity.magnitude);
    }

    private void FixedUpdate()
    {
        if (forward)
        {
            VerticalMove(1);
        }
        else if (backward)
        {
            VerticalMove(-1);
        }
        if (right)
        {
            HorizontalMove(1);

        }
        else if(left)
        {
            HorizontalMove(-1);
        }
    }

    private void VerticalMove(int direction)
    {
        Vector3 tempVelocity = transform.TransformDirection(Vector3.forward) * moveSpeed * direction;
        myBody.velocity = tempVelocity;
    }

    private void HorizontalMove(int direction)
    {
        transform.Rotate(Vector3.up * rotateSpeed * direction);
    }

    #region Highlights
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Highlight"))
        {
            other.GetComponent<InteractiveObject>().ToggleHighlight(true);
            TriggerObject = other;
            RaycastActive = true;
        }
        if(other.CompareTag("Ball"))
        {
            trashTask.CollectTheBalls();
            if (trashTask.ballisThere)
                other.gameObject.SetActive(false);
                trashTask.ballisThere = false;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Highlight"))
        {
            other.GetComponent<InteractiveObject>().ToggleHighlight(false);
            ExitOtherObject = other;
            RaycastActive = false;
        }

    }
    #endregion
}
