using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class VRMovement : MonoBehaviour
{
    List<InputActionAsset> actionAssets;

    [SerializeField] private InputActionManager vr_input;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputActionAsset actionAsset = vr_input.actionAssets[0];
        InputActionMap actionMap = actionAsset.FindActionMap("XRI RightHand Interaction");
        InputAction action = actionMap.FindAction("Activate");

        bool rHandTrigger = action.ReadValue<bool>();

        if (rHandTrigger)
            Debug.Log("Right hand trigger PRESSED");
        else
            Debug.Log("Right hand trigger UNPRESSED");
    }
}
