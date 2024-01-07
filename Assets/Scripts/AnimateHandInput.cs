using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;

    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;

    void Start()
    {
        
    }

    void Update()
    {
        // use a bool for buttons, use float for triggers
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
