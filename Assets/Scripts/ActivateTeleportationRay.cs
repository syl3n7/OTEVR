using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;


public class ActivateTeleportationRay : MonoBehaviour
{
    public AudioClip teleportSound;
    public GameObject leftTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty leftCancel;
    public XRRayInteractor leftRay;
    
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
           audioSource.clip = teleportSound;
    }   
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);
        leftTeleportation.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);
    
    if (leftActivate.action.triggered && leftTeleportation.activeSelf)
        {
             if (teleportSound != null)
            {
                audioSource.PlayOneShot(teleportSound);
            }
        }
    }
}
