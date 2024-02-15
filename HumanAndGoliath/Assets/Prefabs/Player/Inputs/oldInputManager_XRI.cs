using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Management;

public class oldInputManager_XRI : InputManager_Base
{

    private void Awake() {
    }

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

    [SerializeField]
    private InputActionReference refHeadPosition;

    [SerializeField]
    private InputActionReference refHeadRotation;

    [SerializeField]
    private InputActionReference refHeadIsTracked;

    [SerializeField]
    private InputActionReference refHeadTrackingState;

    [SerializeField]
    private InputActionReference refEyeGazePosition;

    [SerializeField]
    private InputActionReference refEyeGazeRotation;

    [SerializeField]
    private InputActionReference refEyeGazeIsTracked;

    [SerializeField]
    private InputActionReference refEyeGazeTrackingState;

    #endregion


    #region ======================================================================================= Left Hand

    [SerializeField]
    private InputActionReference refLeftHandPosition;

    [SerializeField]
    private InputActionReference refLeftHandRotation;

    [SerializeField]
    private InputActionReference refLeftHandIsTracked;

    [SerializeField]
    private InputActionReference refLeftHandTrackingState;

    [SerializeField]
    private InputActionReference refLeftHandHapticDevice;

    [SerializeField]
    private InputActionReference refLeftHandAimPosition;

    [SerializeField]
    private InputActionReference refLeftHandAimRotation;

    [SerializeField]
    private InputActionReference refLeftHandAimFlags;

    [SerializeField]
    private InputActionReference refLeftHandPinchPosition;

    [SerializeField]
    private InputActionReference refLeftHandPokePosition;

    [SerializeField]
    private InputActionReference refLeftHandPokeRotation;

    #endregion

    #region ======================================================================================= Left Hand Interaction

    [SerializeField]
    private InputActionReference refLeftHandSelect;

    [SerializeField]
    private InputActionReference refLeftHandSelectValue;

    [SerializeField]
    private InputActionReference refLeftHandActivate;

    [SerializeField]
    private InputActionReference refLeftHandActivateValue;

    [SerializeField]
    private InputActionReference refLeftHandUIPress;

    [SerializeField]
    private InputActionReference refLeftHandUIPressValue;

    [SerializeField]
    private InputActionReference refLeftHandUIScroll;

    [SerializeField]
    private InputActionReference refLeftHandRotateAnchor;

    [SerializeField]
    private InputActionReference refLeftHandTranslateAnchor;

    #endregion

    #region ======================================================================================= Left Hand Locomotion

    [SerializeField]
    private InputActionReference refLeftHandTeleportSelect;

    [SerializeField]
    private InputActionReference refLeftHandTeleportModeActivate;

    [SerializeField]
    private InputActionReference refLeftHandTeleportModeCancel;

    [SerializeField]
    private InputActionReference refLeftHandTeleportDirection;

    [SerializeField]
    private InputActionReference refLeftHandTurn;

    [SerializeField]
    private InputActionReference refLeftHandMove;

    [SerializeField]
    private InputActionReference refLeftHandGrabMove;

    [SerializeField]
    private InputActionReference refLeftHandSnapTurn;

    #endregion


    #region ======================================================================================= Right Hand

    [SerializeField]
    private InputActionReference refRightHandPosition;

    [SerializeField]
    private InputActionReference refRightHandRotation;

    [SerializeField]
    private InputActionReference refRightHandIsTracked;

    [SerializeField]
    private InputActionReference refRightHandTrackingState;

    [SerializeField]
    private InputActionReference refRightHandHapticDevice;

    [SerializeField]
    private InputActionReference refRightHandAimPosition;

    [SerializeField]
    private InputActionReference refRightHandAimRotation;

    [SerializeField]
    private InputActionReference refRightHandAimFlags;

    [SerializeField]
    private InputActionReference refRightHandPinchPosition;

    [SerializeField]
    private InputActionReference refRightHandPokePosition;

    [SerializeField]
    private InputActionReference refRightHandPokeRotation;

    #endregion

    #region ======================================================================================= Right Hand Interaction

    [SerializeField]
    private InputActionReference refRightHandSelect;

    [SerializeField]
    private InputActionReference refRightHandSelectValue;

    [SerializeField]
    private InputActionReference refRightHandActivate;

    [SerializeField]
    private InputActionReference refRightHandActivateValue;

    [SerializeField]
    private InputActionReference refRightHandUIPress;

    [SerializeField]
    private InputActionReference refRightHandUIPressValue;

    [SerializeField]
    private InputActionReference refRightHandUIScroll;

    [SerializeField]
    private InputActionReference refRightHandRotateAnchor;

    [SerializeField]
    private InputActionReference refRightHandTranslateAnchor;

    #endregion

    #region ======================================================================================= Right Hand Locomotion

    [SerializeField]
    private InputActionReference refRightHandTeleportSelect;

    [SerializeField]
    private InputActionReference refRightHandTeleportModeActivate;

    [SerializeField]
    private InputActionReference refRightHandTeleportModeCancel;

    [SerializeField]
    private InputActionReference refRightHandTeleportDirection;

    [SerializeField]
    private InputActionReference refRightHandTurn;

    [SerializeField]
    private InputActionReference refRightHandMove;

    [SerializeField]
    private InputActionReference refRightHandGrabMove;

    [SerializeField]
    private InputActionReference refRightHandSnapTurn;

    #endregion


    #region ======================================================================================= UI

    [SerializeField]
    private InputActionReference refNavigate;

    [SerializeField]
    private InputActionReference refSubmit;

    [SerializeField]
    private InputActionReference refCancel;

    [SerializeField]
    private InputActionReference refPoint;

    [SerializeField]
    private InputActionReference refClick;

    [SerializeField]
    private InputActionReference refScrollWheel;

    [SerializeField]
    private InputActionReference refMiddleClick;

    [SerializeField]
    private InputActionReference refRightClick;

    #endregion

}
