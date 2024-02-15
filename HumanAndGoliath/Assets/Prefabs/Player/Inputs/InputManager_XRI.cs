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

    public void OnHeadPosition(InputValue input){
        Debug.Log($"OnHeadPosition ${input}");
    }

    public void OnHeadRotation(InputValue input){
        Debug.Log($"OnHeadRotation ${input}");
    }

    public void OnHeadIsTracked(InputValue input){
        Debug.Log($"OnHeadIsTracked ${input}");
    }

    public void OnHeadTrackingState(InputValue input){
        Debug.Log($"OnHeadTrackingState ${input}");
    }

    public void OnEyeGazePosition(InputValue input){
        Debug.Log($"OnEyeGazePosition ${input}");
    }

    public void OnEyeGazeRotation(InputValue input){
        Debug.Log($"OnEyeGazeRotation ${input}");
    }

    public void OnEyeGazeIsTracked(InputValue input){
        Debug.Log($"OnEyeGazeIsTracked ${input}");
    }

    public void OnEyeGazeTrackingState(InputValue input){
        Debug.Log($"OnEyeGazeTrackingState ${input}");
    }

    #endregion


    #region ======================================================================================= Left Hand

    public void OnLeftHandPosition(InputValue input){
        Debug.Log($"OnLeftHandPosition ${input}");
    }

    public void OnLeftHandRotation(InputValue input){
        Debug.Log($"OnLeftHandRotation ${input}");
    }

    public void OnLeftHandIsTracked(InputValue input){
        Debug.Log($"OnLeftHandIsTracked ${input}");
    }

    public void OnLeftHandTrackingState(InputValue input){
        Debug.Log($"OnLeftHandTrackingState ${input}");
    }

    public void OnLeftHandHapticDevice(InputValue input){
        Debug.Log($"OnLeftHandHapticDevice ${input}");
    }

    public void OnLeftHandAimPosition(InputValue input){
        Debug.Log($"OnLeftHandAimPosition ${input}");
    }

    public void OnLeftHandAimRotation(InputValue input){
        Debug.Log($"OnLeftHandAimRotation ${input}");
    }

    public void OnLeftHandAimFlags(InputValue input){
        Debug.Log($"OnLeftHandAimFlags ${input}");
    }

    public void OnLeftHandPinchPosition(InputValue input){
        Debug.Log($"OnLeftHandPinchPosition ${input}");
    }

    public void OnLeftHandPokePosition(InputValue input){
        Debug.Log($"OnLeftHandPokePosition ${input}");
    }

    public void OnLeftHandPokeRotation(InputValue input){
        Debug.Log($"OnLeftHandPokeRotation ${input}");
    }

    #endregion

    #region ======================================================================================= Left Hand Interaction

    public void OnLeftHandSelect(InputValue input){
        Debug.Log($"OnLeftHandSelect ${input}");
    }

    public void OnLeftHandSelectValue(InputValue input){
        Debug.Log($"OnLeftHandSelectValue ${input}");
    }

    public void OnLeftHandActivate(InputValue input){
        Debug.Log($"OnLeftHandActivate ${input}");
    }

    public void OnLeftHandActivateValue(InputValue input){
        Debug.Log($"OnLeftHandActivateValue ${input}");
    }

    public void OnLeftHandUIPress(InputValue input){
        Debug.Log($"OnLeftHandUIPress ${input}");
    }

    public void OnLeftHandUIPressValue(InputValue input){
        Debug.Log($"OnLeftHandUIPressValue ${input}");
    }

    public void OnLeftHandUIScroll(InputValue input){
        Debug.Log($"OnLeftHandUIScroll ${input}");
    }

    public void OnLeftHandRotateAnchor(InputValue input){
        Debug.Log($"OnLeftHandRotateAnchor ${input}");
    }

    public void OnLeftHandTranslateAnchor(InputValue input){
        Debug.Log($"OnLeftHandTranslateAnchor ${input}");
    }

    #endregion

    #region ======================================================================================= Left Hand Locomotion

    public void OnLeftHandTeleportSelect(InputValue input){
        Debug.Log($"OnLeftHandTeleportSelect ${input}");
    }

    public void OnLeftHandTeleportModeActivate(InputValue input){
        Debug.Log($"OnLeftHandTeleportModeActivate ${input}");
    }

    public void OnLeftHandTeleportModeCancel(InputValue input){
        Debug.Log($"OnLeftHandTeleportModeCancel ${input}");
    }

    public void OnLeftHandTeleportDirection(InputValue input){
        Debug.Log($"OnLeftHandTeleportDirection ${input}");
    }

    public void OnLeftHandTurn(InputValue input){
        Debug.Log($"OnLeftHandTurn ${input}");
    }

    public void OnLeftHandMove(InputValue input){
        Debug.Log($"OnLeftHandMove ${input}");
    }

    public void OnLeftHandGrabMove(InputValue input){
        Debug.Log($"OnLeftHandGrabMove ${input}");
    }

    public void OnLeftHandSnapTurn(InputValue input){
        Debug.Log($"OnLeftHandSnapTurn ${input}");
    }

    #endregion


    #region ======================================================================================= Right Hand

    public void OnRightHandPosition(InputValue input){
        Debug.Log($"OnRightHandPosition ${input}");
    }

    public void OnRightHandRotation(InputValue input){
        Debug.Log($"OnRightHandRotation ${input}");
    }

    public void OnRightHandIsTracked(InputValue input){
        Debug.Log($"OnRightHandIsTracked ${input}");
    }

    public void OnRightHandTrackingState(InputValue input){
        Debug.Log($"OnRightHandTrackingState ${input}");
    }

    public void OnRightHandHapticDevice(InputValue input){
        Debug.Log($"OnRightHandHapticDevice ${input}");
    }

    public void OnRightHandAimPosition(InputValue input){
        Debug.Log($"OnRightHandAimPosition ${input}");
    }

    public void OnRightHandAimRotation(InputValue input){
        Debug.Log($"OnRightHandAimRotation ${input}");
    }

    public void OnRightHandAimFlags(InputValue input){
        Debug.Log($"OnRightHandAimFlags ${input}");
    }

    public void OnRightHandPinchPosition(InputValue input){
        Debug.Log($"OnRightHandPinchPosition ${input}");
    }

    public void OnRightHandPokePosition(InputValue input){
        Debug.Log($"OnRightHandPokePosition ${input}");
    }

    public void OnRightHandPokeRotation(InputValue input){
        Debug.Log($"OnRightHandPokeRotation ${input}");
    }

    #endregion

    #region ======================================================================================= Right Hand Interaction

    public void OnRightHandSelect(InputValue input){
        Debug.Log($"OnRightHandSelect ${input}");
    }

    public void OnRightHandSelectValue(InputValue input){
        Debug.Log($"OnRightHandSelectValue ${input}");
    }

    public void OnRightHandActivate(InputValue input){
        Debug.Log($"OnRightHandActivate ${input}");
    }

    public void OnRightHandActivateValue(InputValue input){
        Debug.Log($"OnRightHandActivateValue ${input}");
    }

    public void OnRightHandUIPress(InputValue input){
        Debug.Log($"OnRightHandUIPress ${input}");
    }

    public void OnRightHandUIPressValue(InputValue input){
        Debug.Log($"OnRightHandUIPressValue ${input}");
    }

    public void OnRightHandUIScroll(InputValue input){
        Debug.Log($"OnRightHandUIScroll ${input}");
    }

    public void OnRightHandRotateAnchor(InputValue input){
        Debug.Log($"OnRightHandRotateAnchor ${input}");
    }

    public void OnRightHandTranslateAnchor(InputValue input){
        Debug.Log($"OnRightHandTranslateAnchor ${input}");
    }

    #endregion

    #region ======================================================================================= Right Hand Locomotion

    public void OnRightHandTeleportSelect(InputValue input){
        Debug.Log($"OnRightHandTeleportSelect ${input}");
    }

    public void OnRightHandTeleportModeActivate(InputValue input){
        Debug.Log($"OnRightHandTeleportModeActivate ${input}");
    }

    public void OnRightHandTeleportModeCancel(InputValue input){
        Debug.Log($"OnRightHandTeleportModeCancel ${input}");
    }

    public void OnRightHandTeleportDirection(InputValue input){
        Debug.Log($"OnRightHandTeleportDirection ${input}");
    }

    public void OnRightHandTurn(InputValue input){
        Debug.Log($"OnRightHandTurn ${input}");
    }

    public void OnRightHandMove(InputValue input){
        Debug.Log($"OnRightHandMove ${input}");
    }

    public void OnRightHandGrabMove(InputValue input){
        Debug.Log($"OnRightHandGrabMove ${input}");
    }

    public void OnRightHandSnapTurn(InputValue input){
        Debug.Log($"OnRightHandSnapTurn ${input}");
    }

    #endregion


    #region ======================================================================================= UI

    public void OnNavigate(InputValue input){
        Debug.Log($"OnNavigate ${input}");
    }

    public void OnSubmit(InputValue input){
        Debug.Log($"OnSubmit ${input}");
    }

    public void OnCancel(InputValue input){
        Debug.Log($"OnCancel ${input}");
    }

    public void OnPoint(InputValue input){
        Debug.Log($"OnPoint ${input}");
    }

    public void OnClick(InputValue input){
        Debug.Log($"OnClick ${input}");
    }

    public void OnScrollWheel(InputValue input){
        Debug.Log($"OnScrollWheel ${input}");
    }

    public void OnMiddleClick(InputValue input){
        Debug.Log($"OnMiddleClick ${input}");
    }

    public void OnRightClick(InputValue input){
        Debug.Log($"OnRightClick ${input}");
    }

    #endregion

}
