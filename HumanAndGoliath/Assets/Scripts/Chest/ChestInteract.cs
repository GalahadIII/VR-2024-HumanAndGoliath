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

    public void Interact()
    {
        isOpen = !isOpen;
        openedChest.SetActive(isOpen);
        closedChest.SetActive(!isOpen);
    }
}
