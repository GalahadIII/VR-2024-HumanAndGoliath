using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Management;

public class InputManager_XRI : InputManager_Base
{

    private void Awake() {
    }

    [SerializeField]
    private InputActionReference refDevicePosition;

    [SerializeField]
    private InputActionReference refDeviceRotation;

    private void Update() {
        refDevicePosition.action.Enable();
        Vector3 devicePosition = refDevicePosition.action.ReadValue<Vector3>();
        Debug.Log(devicePosition);
    }

}
