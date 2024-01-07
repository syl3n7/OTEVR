using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{

    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    void Update()
    {
        leftTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
        rightTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
    }

}
