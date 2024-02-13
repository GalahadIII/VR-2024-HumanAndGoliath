using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotate : MonoBehaviour
{
    [SerializeField]
    private Vector2 cameraRotateScalar = new Vector2(1f, -1f);

    [SerializeField]
    private Transform camTransform;

    // private Vector2 cameraRotate = Vector2.zero;
    public void OnCameraRotate(InputValue input){
        Vector2 mouseDelta = input.Get<Vector2>();
        Vector2 mouseDeltaScaled = mouseDelta * cameraRotateScalar;

        Vector3 rotationLocalEuler = camTransform.localRotation.eulerAngles;
        Vector3 rotationDelta = new Vector3(mouseDeltaScaled.y, mouseDeltaScaled.x, 0);

        Vector3 rotFinal = rotationLocalEuler + rotationDelta;

        Debug.Log($"{mouseDelta} {mouseDeltaScaled} {rotationLocalEuler} {rotationDelta} {rotFinal}");

        if (rotFinal.x >  90f && rotFinal.x < 180f) {
            rotFinal.x =  90f;
        }
        if (rotFinal.x < 270f && rotFinal.x > 180f) {
            rotFinal.x = 270f;
        }

        // Vector3 tRot = (camTransform.localRotation * Quaternion.Euler(mouseDeltaScaled.y, mouseDeltaScaled.x, 0)).eulerAngles;
        // Debug.Log(tRot);
        // tRot.x = MathF.Max(90, MathF.Min(270, tRot.x));
        camTransform.localRotation = Quaternion.Euler(rotFinal);
    }

}
