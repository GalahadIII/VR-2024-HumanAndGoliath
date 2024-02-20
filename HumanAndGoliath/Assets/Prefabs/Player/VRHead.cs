using UnityEngine;
using UnityEngine.InputSystem;

public class VRHead : MonoBehaviour
{

    [SerializeField]
    private InputActionReference refHeadPosition;
    private Vector3 headPosition;

    [SerializeField]
    private InputActionReference refHeadRotation;
    private Quaternion headRotation;

    [SerializeField]
    private Transform headTransform;

    private void Update() {
        headPosition = refHeadPosition.action.ReadValue<Vector3>();
        headRotation = refHeadRotation.action.ReadValue<Quaternion>();

        headTransform.SetLocalPositionAndRotation(headPosition, headRotation);
        // headTransform.localPosition = headPosition;
        // headTransform.localRotation = headRotation;

    }
}
