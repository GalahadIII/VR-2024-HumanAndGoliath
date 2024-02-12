using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement_Base : MonoBehaviour
{

    private void FixedUpdate(){
        Logic_MoveXZ();
    }

// ================================================================================================ MoveXZ

    [Header("Speed")]
    [SerializeField]
    private float speed_MoveXZ = 5f;

    private Vector2 input_MoveXZ = Vector2.zero;

    public void OnMoveXZ(InputValue input){
        input_MoveXZ = input.Get<Vector2>();
        Debug.Log($"OnMoveXZ {input_MoveXZ}");
    }

    private void Logic_MoveXZ(){
        transform.Translate(Quaternion.Euler(90, 0, 0) * input_MoveXZ * speed_MoveXZ * Time.fixedDeltaTime);
    }

// ================================================================================================

}
