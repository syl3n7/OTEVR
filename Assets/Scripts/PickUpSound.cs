using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickUpSound : MonoBehaviour
{
    public AudioClip pickupSound;
    private XRGrabInteractable grabInteractable;
    private AudioSource audioSource;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
       grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable == null)
        {
            grabInteractable = gameObject.AddComponent<XRGrabInteractable>();
        }  

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = pickupSound;
        grabInteractable.onSelectEnter.AddListener(OnGrab);
    }

  private void OnGrab(XRBaseInteractor interactor)
    {
        if (pickupSound != null)
        {
            audioSource.PlayOneShot(pickupSound);
        }
    }
}

