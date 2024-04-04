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

    [SerializeField]
    private Vector3 spawnPosition = Vector3.up * 5f;

    [SerializeField]
    private Quaternion spawnRotation = Quaternion.AngleAxis(90, Vector3.forward);

    private GameObject spawnedItem;

    private bool isOpen = false;

    private void Start()
    {
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

        spawnedItem = Instantiate(prefab, transform.position + spawnPosition, transform.rotation * spawnRotation, transform);
    }

    public void CloseChest()
    {
        UpdateChestVisual();

    }

}
