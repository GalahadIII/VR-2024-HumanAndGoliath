using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager_Base : MonoBehaviour
{

    public void OnMoveXZ(InputValue input){
        Debug.Log(input);
    }
    public void OnClick(InputValue input){
        Debug.Log(input);
    }

}
