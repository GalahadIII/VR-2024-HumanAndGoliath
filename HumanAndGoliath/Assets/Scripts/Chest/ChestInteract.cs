using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : MonoBehaviour, IInteractable
{
    [SerializeField]
    private GameObject openedChest;

    [SerializeField]
    private GameObject closedChest;

    private bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started chest script");
    }

    public void Interact(Transform cameraTransform)
    {
        Debug.Log("chest interact");
        bool isPlayerLooking = Physics.Raycast(cameraTransform.position, cameraTransform.forward - this.transform.position, 10);

        if (isPlayerLooking)
        {
            isOpen = !isOpen;
            openedChest.SetActive(isOpen);
            closedChest.SetActive(!isOpen);
        }
    }
}
