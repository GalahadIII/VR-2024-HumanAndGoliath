using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager_XRI : InputManager_Base
{

    public void OnDeviceLost(){
        Debug.Log($"OnDeviceLost");
    }

    public void OnDeviceRegained(){
        Debug.Log($"OnDeviceRegained");
    }

    public void OnControlsChanged(){
        Debug.Log($"OnControlsChanged");
    }


    #region ======================================================================================= gawk gawk 3k

    public Vector3 HeadPosition { get; private set; }

    public void OnHeadPosition(InputAction input){
        Debug.Log($"OnHeadPosition ${input}");
    }

    public void OnHeadRotation(InputAction input){
        Debug.Log($"OnHeadRotation ${input}");
    }

    public void OnHeadIsTracked(InputAction input){
        Debug.Log($"OnHeadIsTracked ${input}");
    }

    public void OnHeadTrackingState(InputAction input){
        Debug.Log($"OnHeadTrackingState ${input}");
    }

    public void OnEyeGazePosition(InputAction input){
        Debug.Log($"OnEyeGazePosition ${input}");
    }

    public void OnEyeGazeRotation(InputAction input){
        Debug.Log($"OnEyeGazeRotation ${input}");
    }

    public void OnEyeGazeIsTracked(InputAction input){
        Debug.Log($"OnEyeGazeIsTracked ${input}");
    }

    public void OnEyeGazeTrackingState(InputAction input){
        Debug.Log($"OnEyeGazeTrackingState ${input}");
    }

    #endregion


    #region ======================================================================================= Left Hand

    public void OnLeftHandPosition(InputAction input){
        Debug.Log($"OnLeftHandPosition ${input}");
    }

    public void OnLeftHandRotation(InputAction input){
        Debug.Log($"OnLeftHandRotation ${input}");
    }

    public void OnLeftHandIsTracked(InputAction input){
        Debug.Log($"OnLeftHandIsTracked ${input}");
    }

    public void OnLeftHandTrackingState(InputAction input){
        Debug.Log($"OnLeftHandTrackingState ${input}");
    }

    public void OnLeftHandHapticDevice(InputAction input){
        Debug.Log($"OnLeftHandHapticDevice ${input}");
    }

    public void OnLeftHandAimPosition(InputAction input){
        Debug.Log($"OnLeftHandAimPosition ${input}");
    }

    public void OnLeftHandAimRotation(InputAction input){
        Debug.Log($"OnLeftHandAimRotation ${input}");
    }

    public void OnLeftHandAimFlags(InputAction input){
        Debug.Log($"OnLeftHandAimFlags ${input}");
    }

    public void OnLeftHandPinchPosition(InputAction input){
        Debug.Log($"OnLeftHandPinchPosition ${input}");
    }

    public void OnLeftHandPokePosition(InputAction input){
        Debug.Log($"OnLeftHandPokePosition ${input}");
    }

    public void OnLeftHandPokeRotation(InputAction input){
        Debug.Log($"OnLeftHandPokeRotation ${input}");
    }

    #endregion

    #region ======================================================================================= Left Hand Interaction

    public void OnLeftHandSelect(InputAction input){
        Debug.Log($"OnLeftHandSelect ${input}");
    }

    public void OnLeftHandSelectValue(InputAction input){
        Debug.Log($"OnLeftHandSelectValue ${input}");
    }

    public void OnLeftHandActivate(InputAction input){
        Debug.Log($"OnLeftHandActivate ${input}");
    }

    public void OnLeftHandActivateValue(InputAction input){
        Debug.Log($"OnLeftHandActivateValue ${input}");
    }

    public void OnLeftHandUIPress(InputAction input){
        Debug.Log($"OnLeftHandUIPress ${input}");
    }

    public void OnLeftHandUIPressValue(InputAction input){
        Debug.Log($"OnLeftHandUIPressValue ${input}");
    }

    public void OnLeftHandUIScroll(InputAction input){
        Debug.Log($"OnLeftHandUIScroll ${input}");
    }

    public void OnLeftHandRotateAnchor(InputAction input){
        Debug.Log($"OnLeftHandRotateAnchor ${input}");
    }

    public void OnLeftHandTranslateAnchor(InputAction input){
        Debug.Log($"OnLeftHandTranslateAnchor ${input}");
    }

    #endregion

    #region ======================================================================================= Left Hand Locomotion

    public void OnLeftHandTeleportSelect(InputAction input){
        Debug.Log($"OnLeftHandTeleportSelect ${input}");
    }

    public void OnLeftHandTeleportModeActivate(InputAction input){
        Debug.Log($"OnLeftHandTeleportModeActivate ${input}");
    }

    public void OnLeftHandTeleportModeCancel(InputAction input){
        Debug.Log($"OnLeftHandTeleportModeCancel ${input}");
    }

    public void OnLeftHandTeleportDirection(InputAction input){
        Debug.Log($"OnLeftHandTeleportDirection ${input}");
    }

    public void OnLeftHandTurn(InputAction input){
        Debug.Log($"OnLeftHandTurn ${input}");
    }

    public void OnLeftHandMove(InputAction input){
        Debug.Log($"OnLeftHandMove ${input}");
    }

    public void OnLeftHandGrabMove(InputAction input){
        Debug.Log($"OnLeftHandGrabMove ${input}");
    }

    public void OnLeftHandSnapTurn(InputAction input){
        Debug.Log($"OnLeftHandSnapTurn ${input}");
    }

    #endregion


    #region ======================================================================================= Right Hand

    public void OnRightHandPosition(InputAction input){
        Debug.Log($"OnRightHandPosition ${input}");
    }

    public void OnRightHandRotation(InputAction input){
        Debug.Log($"OnRightHandRotation ${input}");
    }

    public void OnRightHandIsTracked(InputAction input){
        Debug.Log($"OnRightHandIsTracked ${input}");
    }

    public void OnRightHandTrackingState(InputAction input){
        Debug.Log($"OnRightHandTrackingState ${input}");
    }

    public void OnRightHandHapticDevice(InputAction input){
        Debug.Log($"OnRightHandHapticDevice ${input}");
    }

    public void OnRightHandAimPosition(InputAction input){
        Debug.Log($"OnRightHandAimPosition ${input}");
    }

    public void OnRightHandAimRotation(InputAction input){
        Debug.Log($"OnRightHandAimRotation ${input}");
    }

    public void OnRightHandAimFlags(InputAction input){
        Debug.Log($"OnRightHandAimFlags ${input}");
    }

    public void OnRightHandPinchPosition(InputAction input){
        Debug.Log($"OnRightHandPinchPosition ${input}");
    }

    public void OnRightHandPokePosition(InputAction input){
        Debug.Log($"OnRightHandPokePosition ${input}");
    }

    public void OnRightHandPokeRotation(InputAction input){
        Debug.Log($"OnRightHandPokeRotation ${input}");
    }

    #endregion

    #region ======================================================================================= Right Hand Interaction

    public void OnRightHandSelect(InputAction input){
        Debug.Log($"OnRightHandSelect ${input}");
    }

    public void OnRightHandSelectValue(InputAction input){
        Debug.Log($"OnRightHandSelectValue ${input}");
    }

    public void OnRightHandActivate(InputAction input){
        Debug.Log($"OnRightHandActivate ${input}");
    }

    public void OnRightHandActivateValue(InputAction input){
        Debug.Log($"OnRightHandActivateValue ${input}");
    }

    public void OnRightHandUIPress(InputAction input){
        Debug.Log($"OnRightHandUIPress ${input}");
    }

    public void OnRightHandUIPressValue(InputAction input){
        Debug.Log($"OnRightHandUIPressValue ${input}");
    }

    public void OnRightHandUIScroll(InputAction input){
        Debug.Log($"OnRightHandUIScroll ${input}");
    }

    public void OnRightHandRotateAnchor(InputAction input){
        Debug.Log($"OnRightHandRotateAnchor ${input}");
    }

    public void OnRightHandTranslateAnchor(InputAction input){
        Debug.Log($"OnRightHandTranslateAnchor ${input}");
    }

    #endregion

    #region ======================================================================================= Right Hand Locomotion

    public void OnRightHandTeleportSelect(InputAction input){
        Debug.Log($"OnRightHandTeleportSelect ${input}");
    }

    public void OnRightHandTeleportModeActivate(InputAction input){
        Debug.Log($"OnRightHandTeleportModeActivate ${input}");
    }

    public void OnRightHandTeleportModeCancel(InputAction input){
        Debug.Log($"OnRightHandTeleportModeCancel ${input}");
    }

    public void OnRightHandTeleportDirection(InputAction input){
        Debug.Log($"OnRightHandTeleportDirection ${input}");
    }

    public void OnRightHandTurn(InputAction input){
        Debug.Log($"OnRightHandTurn ${input}");
    }

    public void OnRightHandMove(InputAction input){
        Debug.Log($"OnRightHandMove ${input}");
    }

    public void OnRightHandGrabMove(InputAction input){
        Debug.Log($"OnRightHandGrabMove ${input}");
    }

    public void OnRightHandSnapTurn(InputAction input){
        Debug.Log($"OnRightHandSnapTurn ${input}");
    }

    #endregion


    #region ======================================================================================= UI

    public void OnNavigate(InputAction input){
        Debug.Log($"OnNavigate ${input}");
    }

    public void OnSubmit(InputAction input){
        Debug.Log($"OnSubmit ${input}");
    }

    public void OnCancel(InputAction input){
        Debug.Log($"OnCancel ${input}");
    }

    public void OnPoint(InputAction input){
        Debug.Log($"OnPoint ${input}");
    }

    public void OnClick(InputAction input){
        Debug.Log($"OnClick ${input}");
    }

    public void OnScrollWheel(InputAction input){
        Debug.Log($"OnScrollWheel ${input}");
    }

    public void OnMiddleClick(InputAction input){
        Debug.Log($"OnMiddleClick ${input}");
    }

    public void OnRightClick(InputAction input){
        Debug.Log($"OnRightClick ${input}");
    }

    #endregion

}
