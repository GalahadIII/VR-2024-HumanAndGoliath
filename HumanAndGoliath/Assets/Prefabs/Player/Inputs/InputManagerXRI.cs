using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerXRI : InputManagerBase
{

    [SerializeField]
    private InputActionAsset inputActions;

    private void OnEnable() {
        if (inputActions != null && !inputActions.enabled) {
            // Debug.Log("InputManagerXRI{} OnEnable() inputActions.Enable();");
            inputActions.Enable();
        }
    }
    private void OnDisable() {
        if (inputActions != null &&  inputActions.enabled) {
            // Debug.Log("InputManagerXRI{} OnDisable() inputActions.Disable();");
            inputActions.Disable();
        }
    }

    [SerializeField]
    private InputActionReference refHeadPosition;
    public Vector3 HeadPosition { get; private set; }

    [SerializeField]
    private InputActionReference refHeadRotation;
    public Vector3 HeadRotation { get; private set; }

    private void Update() {

        HeadPosition = refHeadPosition.action.ReadValue<Vector3>();

        HeadRotation = refHeadRotation.action.ReadValue<Vector3>();

    }

}
