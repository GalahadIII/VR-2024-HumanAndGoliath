using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : MonoBehaviour, IInteractable
{
    [SerializeField]
    private GameObject openedChest;

    [SerializeField]
    private GameObject closedChest;

    [SerializeField]
    private GameObject prefab;

    private GameObject spawnedItem;

    private bool isOpen = false;

    private void Start()
    {
        UpdateChestVisual();
    }

    public void Interact()
    {
        isOpen = !isOpen;

        if (isOpen)
        {
            OpenChest();
        }
        else
        {
            CloseChest();
        }

    }

    public void UpdateChestVisual()
    {
        openedChest.SetActive(isOpen);
        closedChest.SetActive(!isOpen);
    }

    public void OpenChest()
    {
        UpdateChestVisual();

        if (!prefab)
        {
            Debug.LogError("prefab not serialized");
            return;
        }

        if (spawnedItem)
        {
            Debug.Log("platform already spawned");
            return;
        }

        Vector3 newPos = transform.position + Vector3.up * 2;
        spawnedItem = Instantiate(prefab, newPos, Quaternion.identity, transform);
    }

    public void CloseChest()
    {
        UpdateChestVisual();

    }

}
