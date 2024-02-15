
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager_KeyboardMouse : InputManager_Base
{

    public void OnMoveXZ(InputValue input) {

        Vector2 raw = input.Get<Vector2>();

    }

}
