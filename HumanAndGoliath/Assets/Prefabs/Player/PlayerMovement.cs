using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement_Base : MonoBehaviour
{

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update(){
        Logic_MoveXZ();
    }

// ================================================================================================ MoveXZ

    [Header("Speed")]
    [SerializeField]
    private float speedMoveXZ = 5f;

    private Vector2 input_MoveXZ = Vector2.zero;

    public void OnMoveXZ(InputValue input) {
        input_MoveXZ = input.Get<Vector2>();
        // Debug.Log($"OnMoveXZ {input}");
    }

    private void Logic_MoveXZ() {
        transform.Translate(Quaternion.Euler(90, cameraPivotTransform.localRotation.eulerAngles.y, 0) * input_MoveXZ * speedMoveXZ * Time.deltaTime);
    }

// ================================================================================================ camera rotate

    [Header("Look around")]
    [SerializeField]
    private Vector2 cameraRotateScalar = new Vector2(0.15f, -0.125f);

    [SerializeField]
    private Transform cameraPivotTransform;

    [SerializeField]
    private Transform cameraOffsetTransform;

    // private Vector2 cameraRotate = Vector2.zero;
    public void OnCameraRotate(InputValue input) {
        if (cameraLocked) {
            return;
        }
        Vector2 mouseDelta = input.Get<Vector2>();
        Vector2 mouseDeltaScaled = mouseDelta * cameraRotateScalar;

        Vector3 rotationCamLocalEuler = cameraPivotTransform.localRotation.eulerAngles;
        Vector3 rotationDelta = new Vector3(mouseDeltaScaled.y, mouseDeltaScaled.x, 0);

        Vector3 rotationFinal = rotationCamLocalEuler + rotationDelta;

        // Debug.Log($"{mouseDelta} {mouseDeltaScaled} {rotationCamLocalEuler} {rotationDelta} {rotationFinal} {Quaternion.Euler(new Vector3(0, rotationFinal.y, 0))*Vector3.forward}");
        Debug.Log($"{rotationFinal.x}");

        // lock when looking under
        if (rotationFinal.x >  90f && rotationFinal.x <= 180f) {
            rotationFinal.x =  90f;
        }
        // lock when looking above
        if (rotationFinal.x < 270f && rotationFinal.x >  180f) {
            rotationFinal.x = 270f;
        }

        // Vector3 tRot = (camTransform.localRotation * Quaternion.Euler(mouseDeltaScaled.y, mouseDeltaScaled.x, 0)).eulerAngles;
        // Debug.Log(tRot);
        // tRot.x = MathF.Max(90, MathF.Min(270, tRot.x));
        cameraPivotTransform.localRotation = Quaternion.Euler(rotationFinal);

    }

    private enum CameraLockMode { Hold, Toggle };

    [Header("Camera lock")]
    [SerializeField]
    private CameraLockMode cameraLockMode = CameraLockMode.Toggle;

    [SerializeField]
    private bool cameraLocked = true;

    public void OnCameraLock(InputValue input) {
        float pressValue = input.Get<float>();
        bool isPressed = pressValue != 0f;

        if (cameraLockMode == CameraLockMode.Toggle) {
            if (isPressed) {
                SetCameraLock(!cameraLocked);
            }
        } else if (cameraLockMode == CameraLockMode.Hold) {
            SetCameraLock(isPressed);
        }

    }

    public void SetCameraLock(bool newCameraLocked) {

        cameraLocked = newCameraLocked;
        if (cameraLocked) {
            Cursor.lockState = CursorLockMode.None;
        } else {
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

// ================================================================================================ camera rotate

}
