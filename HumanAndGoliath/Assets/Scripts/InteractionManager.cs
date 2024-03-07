using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField]
    private Transform cameraTransform;

    [SerializeField]
    private float maxDistance = 1.75f;

    void Update()
    {

        if (!cameraTransform)
        {
            Debug.LogError("Camera transform not serialized");
            return;
        }

        Debug.DrawRay(cameraTransform.position, cameraTransform.forward * maxDistance);

        if (!Input.GetKeyDown(KeyCode.E))
        {
            return;
        }

        bool raycastHit = Physics.Raycast(cameraTransform.position, cameraTransform.forward, out RaycastHit hitinfo, maxDistance);
        if (!raycastHit)
        {
            return;
        }
        GameObject interactableCandidate = hitinfo.collider.gameObject;
        bool interactableValid = interactableCandidate.TryGetComponent<IInteractable>(out IInteractable interactable);
        if (!interactableValid)
        {
            return;
        }

        interactable.Interact();

    }

}
