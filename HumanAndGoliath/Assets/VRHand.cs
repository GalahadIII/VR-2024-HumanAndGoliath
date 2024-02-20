using UnityEngine;
using UnityEngine.InputSystem;

public class VRHand : MonoBehaviour
{

    [SerializeField]
    private InputActionReference refHandPosition;
    private Vector3 handPosition;

    [SerializeField]
    private InputActionReference refHandRotation;
    private Quaternion handRotation;

    [SerializeField]
    private Transform handTransform;

    private void Update() {
        handPosition = refHandPosition.action.ReadValue<Vector3>();
        handRotation = refHandRotation.action.ReadValue<Quaternion>();

        handTransform.SetLocalPositionAndRotation(handPosition, handRotation);
        // handTransform.localPosition = handPosition;
        // handTransform.localRotation = handRotation;

    }
}
