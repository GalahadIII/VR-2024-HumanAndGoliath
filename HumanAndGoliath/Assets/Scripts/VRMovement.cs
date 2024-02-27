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
    [SerializeField] private InputActionReference RH_Trigger_InputRef;
    [SerializeField] private InputActionReference RH_Position_InputRef;
    private Vector3 rh_lastPosition;

    [SerializeField] private Transform completeXRSetup;

    void Start()
    {

    }

    void Update()
    {
        float RH_inputTrigger = RH_Trigger_InputRef.action.ReadValue<float>();
        bool triggered = RH_inputTrigger != 0;
        if (!triggered)
        {
            return;
        }

        Vector3 RH_inputPosition = RH_Position_InputRef.action.ReadValue<Vector3>();
        Vector3 diff = rh_lastPosition - RH_inputPosition;
        completeXRSetup.localPosition += diff;
        rh_lastPosition = RH_inputPosition;
    }
}
