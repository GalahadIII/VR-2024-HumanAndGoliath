using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class VRMovement : MonoBehaviour
{
    Vector2 rHandLastPos = Vector2.zero;

    // [SerializeField] private InputActionReference rightHandPositionRef;
    [SerializeField] private InputActionReference rightHandTriggerRef;
    void Start()
    {

    }

    void Update()
    {
        float rHandTriggerIn = rightHandTriggerRef.action.ReadValue<float>();
        Debug.Log(rHandTriggerIn);

        // if (rHandTriggerIn > 0.5)
        // {
        //     Debug.Log("Right hand trigger PRESSED");
        // }
        // else
        // {
        //     Debug.Log("Right hand trigger UNPRESSED");
        // }
    }
}
