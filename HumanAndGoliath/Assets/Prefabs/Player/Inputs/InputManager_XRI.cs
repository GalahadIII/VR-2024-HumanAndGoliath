using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager_XRI : MonoBehaviour
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

    public void OnPosition(InputAction input){
        Debug.Log($"OnPosition ${input}");
    }

    public void OnRotation(InputAction input){
        Debug.Log($"OnRotation ${input}");
    }

    public void OnIsTracked(InputAction input){
        Debug.Log($"OnIsTracked ${input}");
    }

    public void OnTrackingState(InputAction input){
        Debug.Log($"OnTrackingState ${input}");
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

    public void OnHapticDevice(InputAction input){
        Debug.Log($"OnHapticDevice ${input}");
    }

    public void OnAimPosition(InputAction input){
        Debug.Log($"OnAimPosition ${input}");
    }

    public void OnAimRotation(InputAction input){
        Debug.Log($"OnAimRotation ${input}");
    }

    public void OnAimFlags(InputAction input){
        Debug.Log($"OnAimFlags ${input}");
    }

    public void OnPinchPosition(InputAction input){
        Debug.Log($"OnPinchPosition ${input}");
    }

    public void OnPokePosition(InputAction input){
        Debug.Log($"OnPokePosition ${input}");
    }

    public void OnPokeRotation(InputAction input){
        Debug.Log($"OnPokeRotation ${input}");
    }

    public void OnSelect(InputAction input){
        Debug.Log($"OnSelect ${input}");
    }

    public void OnSelectValue(InputAction input){
        Debug.Log($"OnSelectValue ${input}");
    }

    public void OnActivate(InputAction input){
        Debug.Log($"OnActivate ${input}");
    }

    public void OnActivateValue(InputAction input){
        Debug.Log($"OnActivateValue ${input}");
    }

    public void OnUIPress(InputAction input){
        Debug.Log($"OnUIPress ${input}");
    }

    public void OnUIPressValue(InputAction input){
        Debug.Log($"OnUIPressValue ${input}");
    }

    public void OnUIScroll(InputAction input){
        Debug.Log($"OnUIScroll ${input}");
    }

    public void OnRotateAnchor(InputAction input){
        Debug.Log($"OnRotateAnchor ${input}");
    }

    public void OnTranslateAnchor(InputAction input){
        Debug.Log($"OnTranslateAnchor ${input}");
    }

    public void OnTeleportSelect(InputAction input){
        Debug.Log($"OnTeleportSelect ${input}");
    }

    public void OnTeleportModeActivate(InputAction input){
        Debug.Log($"OnTeleportModeActivate ${input}");
    }

    public void OnTeleportModeCancel(InputAction input){
        Debug.Log($"OnTeleportModeCancel ${input}");
    }

    public void OnTeleportDirection(InputAction input){
        Debug.Log($"OnTeleportDirection ${input}");
    }

    public void OnTurn(InputAction input){
        Debug.Log($"OnTurn ${input}");
    }

    public void OnMove(InputAction input){
        Debug.Log($"OnMove ${input}");
    }

    public void OnGrabMove(InputAction input){
        Debug.Log($"OnGrabMove ${input}");
    }

    public void OnSnapTurn(InputAction input){
        Debug.Log($"OnSnapTurn ${input}");
    }

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


}
