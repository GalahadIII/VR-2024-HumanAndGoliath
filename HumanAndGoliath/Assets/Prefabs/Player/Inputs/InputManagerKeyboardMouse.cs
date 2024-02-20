
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerKeyboardMouse : InputManagerBase
{

    public void OnMoveXZ(InputValue input) {

        Vector2 raw = input.Get<Vector2>();

    }

}
