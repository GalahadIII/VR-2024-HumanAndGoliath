using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : MonoBehaviour, IInteractable
{

    private bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started chest script");
    }

    public void Interact(Transform cameraTransform)
    {
        bool isPlayerLooking = Physics.Raycast(cameraTransform.position, cameraTransform.forward - this.transform.position, 10);

        if (isPlayerLooking)
        {
            Debug.Log("Player looking at object");
        }
    }
}
